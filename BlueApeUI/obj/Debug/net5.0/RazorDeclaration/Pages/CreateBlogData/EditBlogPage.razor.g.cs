// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlueApeUI.Pages.CreateBlogData
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Providers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blog-editor")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/blog-editor/{category}/{title}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/blog-editor/{category}/{title}/{page}")]
    public partial class EditBlogPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
       
    [Parameter]
    public string title { get; set; }
    [Parameter]
    public int page { get; set; }
    [Parameter]
    public string category { get; set; }

    private string _category = "all";
    private BlogData data;

    private BlogSettings blogModel = new BlogSettings("", "", "", "", "", "",
        new List<string>
    (), new List<string>
        (), "", "", "");
    private int _currentPage = 0;

    private PageData[] posts = Array.Empty<PageData>();
    private PageData[] displayedPosts = Array.Empty<PageData>();
    private int subPages = 0;
    ///passed page name to LookForPost
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();
        if (this.page != 0) _currentPage = this.page;
        else _currentPage = 0;
        if (!String.IsNullOrEmpty(category)) _category = category;
        if (!String.IsNullOrEmpty(title))
        {
            var result = await _blogsRepo.getBlogData(title);
            if (result.isSuccess)
            {
                BlogData blogData = JsonConvert.DeserializeObject<BlogData>(result.content);
                data = blogData;
                List<string> currentPages = new List<string>();
                foreach (PageData page in blogData.BlogDocument.Pages) currentPages.Add(page.Title);
                blogModel = new BlogSettings
                (
                blogData.BlogDocument.BlogDetails.Title,
                blogData.BlogDocument.BlogDetails.LogoUrl,
                blogData.BlogDocument.BlogDetails.Description,
                blogData.BlogDocument.BlogDetails.PrimaryColor,
                blogData.BlogDocument.BlogDetails.SecondaryColor,
                blogData.BlogDocument.BlogDetails.BackgroundColor,
                blogData.BlogDocument.Categories.ToList(),
                currentPages.ToList(),
                blogData.BlogDocument.BlogDetails.FacebookLink,
                blogData.BlogDocument.BlogDetails.InstagramLink,
                blogData.BlogDocument.BlogDetails.TwitterLink
                );
                BlogData body = JsonConvert.DeserializeObject<BlogData>
                    (result.content);
                Console.WriteLine(blogModel.title);
                posts = body.BlogDocument.Posts;
                int numberOfPosts = body.BlogDocument.Posts.Length;
                if (numberOfPosts > 9) subPages = Convert.ToInt32(numberOfPosts.ToString().Remove(numberOfPosts.ToString().Length - 1));
            }
        }
        this.RerenderPosts();
    }
    protected void GoToPage(int pageNum)
    {
        _currentPage = pageNum;
        this.RerenderPosts();
        _currentPage = 0;
        Console.WriteLine(_currentPage);
    }
    protected void OpenNewPostPage()
    {
        _navMan.NavigateTo($"/post-editor/{title}");
    }
    private void RerenderPosts()
    {
        int startIndex = _currentPage != 0 ? Convert.ToInt32(Convert.ToString(_currentPage - 1) + "0") : 0;
        int endIndex = _currentPage != 0 ? Convert.ToInt32(Convert.ToString(_currentPage) + "0") : 10;
        this.displayedPosts = Array.Empty<PageData>();
        List<PageData> listPosts = posts.ToList();
        List<PageData> newDisplayedPosts = new List<PageData>();
        listPosts.ForEach(x =>
        {
            int index = listPosts.IndexOf(x);
            if (index >= startIndex && index < endIndex) newDisplayedPosts.Add(x);
        });
        newDisplayedPosts.Reverse();
        this.displayedPosts = newDisplayedPosts.ToArray();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlogsManagerRepository _blogsRepo { get; set; }
    }
}
#pragma warning restore 1591
