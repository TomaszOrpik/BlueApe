using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueApeAPI.Models.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using BlueApeAPI.Models.Users.Requests;
using BlueApeAPI.Models.Users.Responses;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using Serilog;

namespace BlueApeAPI.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        /// <summary>
        /// GET userData
        /// </summary>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UserData()
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                var userData = new UserResponse(user.UserName, user.LastName, user.Email);
                return Ok(userData);
            } catch (Exception e)
            {
                Log.Error("Can't get User Data:", e.Message);
                return StatusCode((int)HttpStatusCode.NotFound);
            }
        }
        /// <summary>
        /// POST Register new User
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Register([FromBody]RegisterEntity model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { Name = model.Name, LastName = model.Name, UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    var token = await this.GenerateJSONWebToken(model.Email, user);
                    DateTime expirationDate = this.GetExpirationDate();
                    var rootData = new UserDataResponse(token, user.UserName, user.Email, expirationDate);
                    return Created("api/v1/authentication/register", rootData);
                }
                return Ok(string.Join(",", result.Errors?.Select(error => error.Description)));
            }
            string errorMessage = string.Join(", ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
            Log.Warning(errorMessage ?? "Bad Request");
            return BadRequest(errorMessage ?? "Bad Request");
        }
        /// <summary>
        /// POST login request to API
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Login([FromBody]LoginEntity model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if (result.Succeeded)
                {
                    var appUser = _userManager.Users.SingleOrDefault(r => r.Email == model.Email);
                    var token = await this.GenerateJSONWebToken(model.Email, appUser);
                    DateTime expirationDate = this.GetExpirationDate();
                    var rootData = new UserDataResponse(token, appUser.UserName, appUser.Email, expirationDate);
                    Log.Warning("Login endpoint reached");
                    return Ok(rootData);
                }
                return StatusCode((int)HttpStatusCode.Unauthorized, "Bad Credentials");
            }
            string errorMessage = string.Join(", ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
            Log.Warning(errorMessage ?? "Bad Request");
            return BadRequest(errorMessage ?? "Bad Request");
        }

        private async Task<string> GenerateJSONWebToken(string email, IdentityUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };
            var userMail = await _userManager.FindByEmailAsync(email);
            var roles = await _userManager.GetRolesAsync(userMail);
            claims.AddRange(roles.Select(r => new Claim(ClaimsIdentity.DefaultRoleClaimType, r)));

            var token = new JwtSecurityToken(_configuration["JwtIssuer"]
                , _configuration["JwtIssuer"],
                claims,
                null,
                expires: DateTime.Now.AddHours(5),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private DateTime GetExpirationDate()
        {
            DateTime now = DateTime.Now;
            return now.AddMinutes(30);
        }
    }
}
