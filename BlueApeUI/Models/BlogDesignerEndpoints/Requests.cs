using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueApeUI.Models.Requests
{
    public class BlogDeleteRequestBody
    {
        public string Title { get; set; }
        public string UserEmail { get; set; }
    }
    public class BlogRequestBody
    {
        public string UserEmail { get; set; }
        public BlogData data { get; set; }
    }
    public class PostRequestBody
    {
        public string BlogName { get; set; }
        public PageData Data { get; set; }
    }
    public class BlogData
    {
        public BlogDocument BlogDocument { get; set; }
    }
    public class BlogDocument
    {
        public BlogDetails BlogDetails { get; set; }
        public UserDetails UserDetails { get; set; }
        public PageData[] Pages { get; set; }
        public string[] Categories { get; set; }
        public PageData[] Posts { get; set; }
    }
    public class BlogDetails
    {
        public string Title { get; set; }
        public string LogoUrl { get; set; }
        public string Description { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string BackgroundColor { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
    }
    public class UserDetails
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class PageData
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string[] Categories { get; set; }
        public string Date { get; set; }
        public string Intro { get; set; }
        public string Content { get; set; }
    }
}
