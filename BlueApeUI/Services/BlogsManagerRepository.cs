using BlueApeUI.Contracts;
using BlueApeUI.Models.Responses;
using BlueApeUI.Models.Requests;
using BlueApeUI.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlueApeUI.Services
{
    public class BlogsManagerRepository : IBlogsManagerRepository
    {
        private readonly HttpClient _client;
        public BlogsManagerRepository(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("baseClient");
        }
        public async Task<ResponseModel> postBlogData(BlogRequestBody body)
        {
            string json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_client.BaseAddress}api/v1/Blogs/CreateBlog", content);
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
        public async Task<ResponseModel> checkIfExist(string name)
        {
            var response = await _client.GetAsync($"{_client.BaseAddress}api/v1/Blogs/LookForBlog/{name}").ConfigureAwait(false);
            IsExistResponse responseData = await response.Content.ReadFromJsonAsync<IsExistResponse>();
            return ResponseUtilities.ResponseValidation(response.StatusCode, responseData.isExist ? "true" : "false");
        }
        public async Task<ResponseModel> getBlogData(string name)
        {
            var response = await _client.GetAsync($"{_client.BaseAddress}api/v1/Blogs/GetBlogData/{name}").ConfigureAwait(false);
            string responseContent = await response.Content.ReadAsStringAsync();
            return ResponseUtilities.ResponseValidation(response.StatusCode, responseContent);
        }
        public async Task<ResponseModel> getUserBlogs(string userName)
        {
            var response = await _client.GetAsync($"{_client.BaseAddress}api/v1/Blogs/GetUserBlogs/{userName}").ConfigureAwait(false);
            string repsonseContent = await response.Content.ReadAsStringAsync();
            return ResponseUtilities.ResponseValidation(response.StatusCode, repsonseContent);
        }
        public async Task<ResponseModel> updateBlogData(BlogRequestBody body)
        {
            string json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_client.BaseAddress}api/v1/Blogs/UpdateBlogData", content);
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
        public async Task<ResponseModel> deleteBlog(string name)
        {
            var response = await _client.DeleteAsync($"{_client.BaseAddress}api/v1/Blogs/DeleteBlog/{name}");
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
        public async Task<ResponseModel> lookForPost(string blogName, string postName)
        {
            var response = await _client.GetAsync($"{_client.BaseAddress}api/v1/Blogs/LookForPost/{blogName}/{postName}").ConfigureAwait(false);
            IsExistResponse responseData = await response.Content.ReadFromJsonAsync<IsExistResponse>();
            return ResponseUtilities.ResponseValidation(response.StatusCode, responseData.isExist ? "true" : "false");
        }
        public async Task<ResponseModel> getPost(string blogName, string postName)
        {
            var response = await _client.GetAsync($"{_client.BaseAddress}api/v1/Blogs/GetPostData/{blogName}/{postName}").ConfigureAwait(false);
            string responseContent = await response.Content.ReadAsStringAsync();
            return ResponseUtilities.ResponseValidation(response.StatusCode, responseContent);
        }
        public async Task<ResponseModel> getPage(string blogName, string pageName)
        {
            var response = await _client.GetAsync($"{_client.BaseAddress}api/v1/Blogs/GetPageData/{blogName}/{pageName}").ConfigureAwait(false);
            string responseContent = await response.Content.ReadAsStringAsync();
            return ResponseUtilities.ResponseValidation(response.StatusCode, responseContent);
        }
        public async Task<ResponseModel> addPost(BlogData body)
        {
            string json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_client.BaseAddress}api/v1/Blogs/AddPostData", content);
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
        public async Task<ResponseModel> addPage(BlogData body)
        {
            string json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_client.BaseAddress}api/v1/Blogs/AddPageData", content);
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
        public async Task<ResponseModel> updatePost(BlogData body)
        {
            string json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_client.BaseAddress}api/v1/Blogs/UpdatePostData", content);
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
        public async Task<ResponseModel> updatePage(BlogData body)
        {
            string json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_client.BaseAddress}api/v1/Blogs/UpdatePageData", content);
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
        public async Task<ResponseModel> deletePost(string blogName, string postName)
        {
            var response = await _client.DeleteAsync($"{_client.BaseAddress}api/v1/Blogs/DeletePostData/{blogName}/{postName}");
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
        public async Task<ResponseModel> deletePage(string blogName, string pageName)
        {
            var response = await _client.DeleteAsync($"{_client.BaseAddress}api/v1/Blogs/DeletePageData/{blogName}/{pageName}");
            return ResponseUtilities.ResponseValidation(response.StatusCode, string.Empty);
        }
    }
}
