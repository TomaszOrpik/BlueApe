using BlueApeAPI.Contracts;
using BlueApeAPI.Models;
using BlueApeAPI.Models.Collections;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace BlueApeAPI.Services
{
    public class BlogDataService : IBlogDataService
    {
        private readonly IMongoDatabase _database;
        private readonly IDatabaseSettings _settings;
        public BlogDataService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.Database);
            _settings = settings;
        }
        // get data of collection with specific name
        public BlogGetData GetCollectionData(string name)
        {
            return _database.GetCollection<BlogGetData>(name).Find(data => true).FirstOrDefault();
        }
        // Update collection for specific user
        public void UpdateCollectionData(BlogData data) {
            var update = Builders<BlogData>.Update.Set("BlogDocument", data.BlogDocument);
            _database.GetCollection<BlogData>(data.BlogDocument.BlogDetails.Title).UpdateOne(data => true, update);
        }
        // create new user collection and insert blog into
        public void CreateCollectionData(BlogData data)
        {
            _database.CreateCollection(data.BlogDocument.BlogDetails.Title);
            var user = new BsonDocument
            {
                { "createUser", data.BlogDocument.UserDetails.UserName },
                { "pwd", data.BlogDocument.UserDetails.Password },
                { "roles", new BsonArray {
                    new BsonDocument {
                            { "role", "readWrite" },
                            { "db", _settings.Database },
                            {"collection", data.BlogDocument.BlogDetails.Title }
                        }
                    }
                }
            };
            _database.RunCommand<BsonDocument>(user);
            _database.GetCollection<BlogData>(data.BlogDocument.BlogDetails.Title).InsertOne(data);
        }
        // delete specific user and collection
        public void DeleteCollectionData(string name, string userName) {
            var deleteUser = new BsonDocument { {"dropUser", userName } };
            _database.RunCommand<BsonDocument>(deleteUser);
            _database.DropCollection(name);
        }
        // check if specific post exist in blog
        public bool LookForPost(string blogName, string postName)
        {
            var postsList = _database.GetCollection<BlogGetData>(blogName)
                .Find(data => true).FirstOrDefault()
                .BlogDocument.Posts.Where(p => p.Title == postName);
            if (postsList != null) return true;
            else return false;
        }
        // get specific post
        public PageData GetPost(string blogName, string postName)
        {
            PageData[] posts = _database.GetCollection<BlogGetData>(blogName)
                .Find(data => true).FirstOrDefault()
                .BlogDocument.Posts;
            return posts.Where(p => p.Title == postName).FirstOrDefault();
        }
        // get specific page
        public PageData GetPage(string blogName, string pageName)
        {
            PageData[] pages = _database.GetCollection<BlogGetData>(blogName)
                .Find(data => true).FirstOrDefault()
                .BlogDocument.Pages;
            return pages.Where(p => p.Title == pageName).FirstOrDefault();
        }
        // add new post
        public void AddPost(string blogName, PageData post)
        {
            BlogDocument document = _database.GetCollection<BlogGetData>(blogName)
                .Find(data => true).FirstOrDefault().BlogDocument;
            PageData[] posts = document.Posts;
            List<PageData> listPosts = posts.ToList();
            listPosts.Add(post);
            PageData[] newPosts = listPosts.ToArray();
            document.Posts = newPosts;
            var update = Builders<BlogData>.Update.Set("BlogDocument", document);
            _database.GetCollection<BlogData>(blogName).UpdateOne(data => true, update);
        }
        // add new page
        public void AddPage(string blogName, PageData page)
        {
            BlogDocument document = _database.GetCollection<BlogGetData>(blogName)
                .Find(data => true).FirstOrDefault().BlogDocument;
            PageData[] pages = document.Pages;
            List<PageData> listPages = pages.ToList();
            listPages.Add(page);
            PageData[] newPosts = listPages.ToArray();
            document.Pages = newPosts;
            var update = Builders<BlogData>.Update.Set("BlogDocument", document);
            _database.GetCollection<BlogData>(blogName).UpdateOne(data => true, update);
        }
        // update existing post
        public void UpdatePost(BlogData data)
        {
            var update = Builders<BlogData>.Update.Set("BlogDocument", data.BlogDocument);
            _database.GetCollection<BlogData>(data.BlogDocument.BlogDetails.Title).UpdateOne(data => true, update);
        }
        // update existing page
        public void UpdatePage(BlogData data)
        {
            var update = Builders<BlogData>.Update.Set("BlogDocument", data.BlogDocument);
            _database.GetCollection<BlogData>(data.BlogDocument.BlogDetails.Title).UpdateOne(data => true, update);
        }
        // delete post
        public void DeletePost(string blogName, string postName)
        {
            BlogDocument document = _database.GetCollection<BlogGetData>(blogName)
                .Find(data => true).FirstOrDefault().BlogDocument;
            PageData post = document.Posts.Where(p => p.Title == postName).FirstOrDefault();
            List<PageData> listPosts = document.Posts.ToList();
            listPosts.Remove(post);
            document.Posts = listPosts.ToArray();
            var update = Builders<BlogData>.Update.Set("BlogDocument", document);
            _database.GetCollection<BlogData>(blogName).UpdateOne(data => true, update);
        }
        // delete page
        public void DeletePage(string blogName, string pageName)
        {
            BlogDocument document = _database.GetCollection<BlogGetData>(blogName)
                .Find(data => true).FirstOrDefault().BlogDocument;
            PageData page = document.Pages.Where(p => p.Title == pageName).FirstOrDefault();
            List<PageData> listPages = document.Pages.ToList();
            listPages.Remove(page);
            document.Pages = listPages.ToArray();
            var update = Builders<BlogData>.Update.Set("BlogDocument", document);
            _database.GetCollection<BlogData>(blogName).UpdateOne(data => true, update);
        }
    }
}

