#pragma checksum "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efed62d464ed7250cb89c63fd0a3191c647d873e"
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
#line 1 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Models.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Providers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\_Imports.razor"
using BlueApeUI.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
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
#line 13 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
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
#line 17 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                     blogModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "scale", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                       2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "activeButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 18 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
     if(posts.Length > 0)
    {
        ///newest post
    }
    else
    {
        ///some div for margin top
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<div class=\"container\"></div>\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "moveRight");
            __builder.OpenComponent<BlueApeUI.Shared.BlogFooter>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(16, "<h3>EditBlogPage</h3>\r\n");
            __builder.AddMarkupContent(17, "<div>Add post container on click - redirect to create post/page container without post data</div>\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "width: 200px; height: 200px; background-color: red");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                                          OpenNewPostPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Click to go to post edytor");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "posts");
#nullable restore
#line 43 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
     for (int p = 0; p < 10; p++)
    {
        int activePage = Convert.ToInt32((page > 0 ? page.ToString() : "") + p.ToString());
        if (activePage < posts.Length)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "blogViewContainer");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                         args => OpenPostPage(posts[activePage])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "title", 
#nullable restore
#line 49 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                       posts[activePage].Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "imageUrl", 
#nullable restore
#line 50 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                          posts[activePage].ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "intro", 
#nullable restore
#line 51 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                       posts[activePage].Intro

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
#nullable restore
#line 56 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
     if (subPages > 0)
    {
        for (int x = 0; x > subPages; x++)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "pageCount");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                             args => GoToPage(x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 60 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
                                                                   x

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "    Pages\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\nDodać for loop + if do sprawdzenia czy element istnieje, create page selector for every 10 elements\r\n");
            __builder.AddMarkupContent(39, "<style>\r\n    .pageCount {\r\n        width: 50px;\r\n        height: 50px;\r\n        border: 1px solid black;\r\n    }\r\n\r\n    .moveRight {\r\n        position: absolute;\r\n        top: 0;\r\n        left: 60px;\r\n        width: calc(100% - 60px);\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreateBlogData\EditBlogPage.razor"
       
    [Parameter]
    public string title { get; set; }
    [Parameter]
    public int page { get; set; }
    [Parameter]
    public string category { get; set; }

    private BlogSettings blogModel = new BlogSettings("", "", "", "", "", "",
        new List<string>(), new List<string>(), "", "", "");
    private int _currentPage = 0;

    private PageData[] posts = Array.Empty<PageData>();
    private int subPages = 0;
    ///passed page name to LookForPost
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();
        if (this.page != 0) _currentPage = this.page;
        if (!String.IsNullOrEmpty(title))
        {
            var result = await _blogsRepo.getBlogData(title);
            if (result.isSuccess)
            {
                BlogData blogData = JsonConvert.DeserializeObject<BlogData>(result.content);
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
                BlogData body = JsonConvert.DeserializeObject<BlogData>(result.content);
                Console.WriteLine(blogModel.title);
                posts = body.BlogDocument.Posts;
                subPages = posts.Count() > 9 ?
                    Convert.ToInt32(posts.Count().ToString().Remove(posts.Count().ToString().Length - 1)) : 0;
            }
        }
    }
    protected void GoToPage(int pageNum) //to change add category
    {
        _navMan.NavigateTo($"/page-editor/{title}/{pageNum}");
    }
    protected void OpenPostPage(PageData postPage)
    {
        ///redirect to edit post/page subpage with blog name and postPage as parameters
    }
    protected void OpenNewPostPage() //to change add category
    {
        _navMan.NavigateTo($"/page-editor/{title}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlogsManagerRepository _blogsRepo { get; set; }
    }
}
#pragma warning restore 1591