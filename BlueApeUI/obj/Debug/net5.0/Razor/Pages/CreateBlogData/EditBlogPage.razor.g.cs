#pragma checksum "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1315a76c3eb9c19bc088e7798e3577c84b2d41d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlueApeUI.Pages.CreateBlogData
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Providers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "navigation");
            __builder.OpenComponent<BlueApeUI.Shared.NavMenu>(2);
            __builder.AddAttribute(3, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                     title

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "moveRight");
            __builder.OpenComponent<BlueApeUI.Shared.BlogNav>(7);
            __builder.AddAttribute(8, "model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlueApeUI.Models.BlogSettings>(
#nullable restore
#line 17 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                     blogModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "scale", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                       2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "activeButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "container");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "bodySquare");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                      OpenNewPostPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "<div class=\"squareBase square\"><div class=\"addText\">\r\n                CREATE NEW POST\r\n            </div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenComponent<BlueApeUI.Shared.BlogPosts>(19);
            __builder.AddAttribute(20, "posts", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlueApeUI.Models.Requests.PageData[]>(
#nullable restore
#line 27 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                       displayedPosts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "isActive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                                title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "scale", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                                              2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
#nullable restore
#line 30 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
             for (int x = 0; x <= subPages; x++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "pageCount");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                 args => GoToPage(x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, 
#nullable restore
#line 32 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                                       x

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "moveRight");
            __builder.OpenComponent<BlueApeUI.Shared.BlogFooter>(34);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.AddMarkupContent(36, @"<style>
    .container {
        margin-top: 160px;
    }

    .bodySquare {
        width: 75%;
        height: 300px;
    }

    .squareBase {
        width: 125%;
        height: 250px;
        cursor: pointer;
    }

    .square {
        border: 2px dashed black;
        background-color: #b3e5fc;
    }

        .square:hover {
            background-color: #4fc3f7;
        }

    .addText {
        Margin: 100px 0;
        line-height: 30px;
        text-align: center;
        font-weight: 700;
        font-size: 36px;
    }
    .pageCount {
        width: 50px;
        height: 50px;
        border: 1px dashed black;
        margin-bottom: 25px;
        margin-right: 25px;
        line-height: 50px;
        text-align: center;
        font-weight: 900;
        font-size: 26px;
        cursor: pointer;
    }

    .moveRight {
        position: absolute;
        top: 0;
        left: 60px;
        width: calc(100% - 60px);
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\sycho\OneDrive\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
       
    [Parameter]
    public string title { get; set; }
    [Parameter]
    public int page { get; set; }
    [Parameter]
    public string category { get; set; }

    private string _category = "all";

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
                BlogData blogData = JsonConvert.DeserializeObject<BlogData>
                    (result.content);
                List<string>
                    currentPages = new List<string>
                        ();
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
