using BlueApeAPI.Contracts;
using BlueApeAPI.Models;
using BlueApeAPI.Models.Collections;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace BlueApeAPI.Services
{
    public class BlogsService : IBlogsService
    {
        private readonly IMongoCollection<BlogCollection> _blogs;
        public BlogsService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.Database);

            var filter = new BsonDocument("name", "BlogsCollection");
            var options = new ListCollectionNamesOptions { Filter = filter };
            bool collectionExist = database.ListCollectionNames(options).Any();
            if (!collectionExist) database.CreateCollection("BlogsCollection");

            _blogs = database.GetCollection<BlogCollection>("BlogsCollection");
        }
        // create new blog
        public void CreateBlog(BlogCollection blogsCollection) {  
            _blogs.InsertOne(blogsCollection);
        }
        // find blog for specific userName
        public string[] GetUserBlogs(string userName)
        {
            List<string> names = new List<string>();
            IList<BlogCollection> blogs = _blogs.Find(blog => blog.UserEmail == userName).ToList();
            foreach (BlogCollection blog in blogs) names.Add(blog.BlogName);
            return names.ToArray();

        }
        // find blog with specific name in collection
        public BlogCollection FindBlog(string name) =>  _blogs.Find(blog => blog.BlogName == name).SingleOrDefault();
        // get all blogs
        public IList<BlogCollection> Read() => _blogs.Find(blog => true).ToList();
        // Delete blog with specific name
        public void DeleteBlog(string name) => _blogs.DeleteOne(blog => blog.BlogName == name);
        /// Search database for specific blog
        public bool LookForBlog(string name)
        {
            var blogsList = _blogs.Find(blog => blog.BlogName == name).FirstOrDefault();
            if (blogsList != null) return true;
            else return false;
        }

        public PageData GetPage(string blogName, string pageName)
        {
            throw new System.NotImplementedException();
        }

        public void AddPage(string blogName, PageData page)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePage(string blogName, PageData page)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePage(string blogName, string pageName)
        {
            throw new System.NotImplementedException();
        }
    }
}
