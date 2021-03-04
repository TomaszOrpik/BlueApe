using BlueApeAPI.Contracts;
using BlueApeAPI.Models.Collections;
using BlueApeAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BlueApeAPI.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class BlogsController : Controller
    {
        private readonly IBlogsService _blogsService;
        private readonly IBlogDataService _blogDataService;
        public BlogsController(IBlogsService blogsService, IBlogDataService blogDataService)
        {
            _blogsService = blogsService;
            _blogDataService = blogDataService;
        }
        /// <summary>
        /// Check if blog with specific name exists in database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{name}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult LookForBlog(string name)
        {
            try
            {
                var response = new { isExist = _blogsService.LookForBlog(name) };
                Log.Warning(response.ToString());
                return Ok(response);
            } catch (Exception e)
            {
                Log.Error("Can't get Blog Data:", e.Message);
                return StatusCode((int)HttpStatusCode.NotFound);
            }
        }
        /// <summary>
        /// Get all blog names for specific user
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpGet("{userName}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult GetUserBlogs(string userName)
        {
            try
            {
                var response = new { blogNames = _blogsService.GetUserBlogs(userName) };
                if (response.blogNames.Count() == 0) return NotFound();
                Log.Warning(response.ToString());
                return Ok(response);
            } catch (Exception e)
            {
                Log.Warning($"Incorred Request - error: {e.Message}");
                return BadRequest(e.Message);
            }

        }
        /// <summary>
        /// Creates new blog in database and adds user-blog pair
        /// </summary>
        /// <param name="blogRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateBlog([FromBody] BlogRequestBody blogRequest)
        {
            try
            {
                _blogDataService.CreateCollectionData(blogRequest.data);
                var newBlog = new BlogCollection() 
                { 
                    UserEmail = blogRequest.UserEmail,
                    BlogName = blogRequest.data.BlogDocument.BlogDetails.Title
                };
                _blogsService.CreateBlog(newBlog);
                return NoContent();
            } catch (Exception e)
            {
                Log.Warning($"Incorred Request - error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Get selected blog data from blogs database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{name}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult GetBlogData(string name)
        {
            try
            {
                var data = _blogDataService.GetCollectionData(name);
                if (data is null) return NotFound();
                BlogData returnData = new BlogData { BlogDocument = data.BlogDocument };
                return Ok(data);
            }
            catch (Exception e) 
            {
                Log.Warning($"Error occured: {e.Message}");
                return BadRequest(e.Message);
            }            
        }
        /// <summary>
        /// Update passed blog in blogs database
        /// </summary>
        /// <param name="blogRequest"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult UpdateBlogData([FromBody] BlogRequestBody blogRequest) //{"Element '_id' does not match any field or property of class BlueApeAPI.Models.Collections.BlogData."}
        {
            try
            {
                _blogDataService.UpdateCollectionData(blogRequest.data);
                return NoContent();
            } catch (Exception e)
            {
                Log.Warning($"Request ended with error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Return blog with passed name and userName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpDelete("{name}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult DeleteBlog(string name)
        {
            try
            {
                var data = _blogDataService.GetCollectionData(name);
                if (data is null) return NotFound();
                _blogDataService.DeleteCollectionData(data.BlogDocument.BlogDetails.Title, data.BlogDocument.UserDetails.UserName);
                _blogsService.DeleteBlog(data.BlogDocument.BlogDetails.Title);
                return NoContent();
            } catch (Exception e)
            {
                Log.Warning($"Request ended with error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Check if post with specific name exists in blog with specific name
        /// </summary>
        /// <param name="blogName"></param>
        /// <param name="postName"></param>
        /// <returns></returns>
        [HttpGet("{blogName}/{postName}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult LookForPost(string blogName, string postName)
        {
            try
            {
                var response = new { 
                    isExist = _blogDataService.LookForPost(blogName, postName) 
                };
                Log.Warning(response.ToString());
                return Ok(response);
            }
            catch (Exception e)
            {
                Log.Error("Can't get Post Data:", e.Message);
                return StatusCode((int)HttpStatusCode.NotFound);
            }
        }
        /// <summary>
        /// Return content of post with specific name from specific blog
        /// </summary>
        /// <param name="blogName"></param>
        /// <param name="postName"></param>
        /// <returns></returns>
        [HttpGet("{blogName}/{postName}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult GetPostData(string blogName, string postName)
        {
            try
            {
                var data = _blogDataService.GetPost(blogName, postName);
                if (data is null) return NotFound();
                return Ok(data);
            } catch(Exception e)
            {
                Log.Warning($"Request ended with error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Return content of page with specific name from specific blog
        /// </summary>
        /// <param name="blogName"></param>
        /// <param name="pageName"></param>
        /// <returns></returns>
        [HttpGet("{blogName}/{pageName}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult GetPageData(string blogName, string pageName)
        {
            try
            {
                var data = _blogDataService.GetPage(blogName, pageName);
                if (data is null) return NotFound();
                return Ok(data);
            }
            catch (Exception e)
            {
                Log.Warning($"Request ended with error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Update post for specific blog
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult AddPostData([FromBody] BlogData data)
        {
            try
            {
                _blogDataService.AddPost(data.BlogDocument.BlogDetails.Title, 
                    data.BlogDocument.Posts[data.BlogDocument.Posts.Length-1]);
                return NoContent();
            } catch(Exception e)
            {
                Log.Warning($"Request ended with error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Update passed post in specific blog
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult UpdatePostData([FromBody] BlogData data)
        {
            try
            {
                _blogDataService.UpdatePost(data);
                return NoContent();
            }
            catch (Exception e)
            {
                Log.Warning($"Request ended with error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// delete post with passed name from blog with specific name
        /// </summary>
        /// <param name="blogName"></param>
        /// <param name="postName"></param>
        /// <returns></returns>
        [HttpDelete("{blogName}/{postName}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult DeletePostData(string blogName, string postName)
        {
            try
            {
                _blogDataService.DeletePost(blogName, postName);
                return NoContent();
            }
            catch (Exception e)
            {
                Log.Warning($"Request ended with error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// delete page with passed name from blog with specific name
        /// </summary>
        /// <param name="blogName"></param>
        /// <param name="pageName"></param>
        /// <returns></returns>
        [HttpDelete("{blogName}/{pageName}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult DeletePageData(string blogName, string pageName)
        {
            try
            {
                _blogDataService.DeletePage(blogName, pageName);
                return NoContent();
            }
            catch (Exception e)
            {
                Log.Warning($"Request ended with error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
    }
}
