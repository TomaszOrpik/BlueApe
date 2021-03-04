using BlueApeAPI.Models.Collections;
using System.Collections.Generic;

namespace BlueApeAPI.Contracts
{
    public interface IBlogsService
    {
        public void CreateBlog(BlogCollection blogsCollection);
        public BlogCollection FindBlog(string name);
        public string[] GetUserBlogs(string userName);
        public IList<BlogCollection> Read();
        public void DeleteBlog(string name);
        public bool LookForBlog(string name);
    }
}
