using BlueApeUI.Models.Responses;
using BlueApeUI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueApeUI.Contracts
{
    public interface IBlogsManagerRepository
    {
        public Task<ResponseModel> postBlogData(BlogRequestBody body);
        public Task<ResponseModel> checkIfExist(string name);
        public Task<ResponseModel> getBlogData(string name);
        public Task<ResponseModel> getUserBlogs(string userName);
        public Task<ResponseModel> updateBlogData(BlogRequestBody body);
        public Task<ResponseModel> deleteBlog(string name);
        public Task<ResponseModel> lookForPost(string blogName, string postName);
        public Task<ResponseModel> getPost(string blogName, string postName);
        public Task<ResponseModel> addPost(BlogData body);
        public Task<ResponseModel> updatePost(BlogData body);
        public Task<ResponseModel> deletePost(string blogName, string postName);
    }
}
