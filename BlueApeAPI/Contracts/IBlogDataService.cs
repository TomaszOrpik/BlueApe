using BlueApeAPI.Models.Collections;

namespace BlueApeAPI.Contracts
{
    public interface IBlogDataService
    {
        public BlogGetData GetCollectionData(string name);
        public void UpdateCollectionData(BlogData data);
        public void CreateCollectionData(BlogData data);
        public void DeleteCollectionData(string name, string userName);
        public bool LookForPost(string blogName, string postName);
        public PageData GetPost(string blogName, string postName);
        public PageData GetPage(string blogName, string pageName);
        public void AddPost(string blogName, PageData post);
        public void UpdatePost(BlogData post);
        public void DeletePost(string blogName, string postName);
        public void DeletePage(string blogName, string pageName);
    }
}
