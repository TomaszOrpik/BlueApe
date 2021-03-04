using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BlueApeUI.Models.Users.Responses
{
    public class LoginResponse
    {
        public LoginResponse(string token, string userName, string email)
        {
            Token = token;
            UserName = userName;
            Email = email;
        }

        public string Token { get; private set; }

        public string UserName { get; private set; }

        public string Email { get; private set; }
    }

    public class SignUpResponse
    {
        public SignUpResponse(string token, string userName, string email)
        {
            Token = token;
            UserName = userName;
            Email = email;
        }

        public string Token { get; private set; }

        public string UserName { get; private set; }

        public string Email { get; private set; }
    }

    public class UserDataResponse
    {
        public UserDataResponse(string token, string userName, string email, DateTime expirationDate)
        {
            Token = token;
            UserName = userName;
            Email = email;
            ExpirationDate = expirationDate;
        }

        public string Token { get; private set; }

        public string UserName { get; private set; }

        public string Email { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public HttpStatusCode? StatusCode { get; set; }
}
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public string[] Errors { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
