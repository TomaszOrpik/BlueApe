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
#line 7 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\NewBlogPage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\NewBlogPage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blog-designer")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/blog-designer/{title}")]
    public partial class NewBlogPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\sycho\Desktop\GitHub\BlueApe\BlueApeUI\Pages\CreateBlogData\NewBlogPage.razor"
       
    [Parameter]
    public string title { get; set; }

    [CascadingParameter]
    public Task<AuthenticationState> authenticationStateTask { get; set; }

    private string _userName;

    BlogSettings model = new BlogSettings
    (
        "BlueApe Template",
        "./Assets/BlueMonkeyLogo.png",
        "Test template for your blog",
        "#224CFF",
        "#2f2f2f",
        "#000000",
        new List<string> { "Category A", "Category B", "Category C" },
        new List<string> { "About Us", "Contact" },
        "https://www.facebook.com",
        "https://www.instagram.com",
        "https://www.twitter.com"
    );
    private List<PageData> pages = new List<PageData>();
    private UserDetails currentUser;
    private List<PageData> posts = new List<PageData>();

    private string errorMessage = string.Empty;
    Models.AlertMessageTypes errorMessageType = Models.AlertMessageTypes.Success;

    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var authenticationState = await authenticationStateTask;
        _userName = authenticationState.User.Identity.Name;
        if (!string.IsNullOrEmpty(title))
        {
            var result = await _blogsRepo.getBlogData(title);
            if (result.isSuccess)
            {
                BlogData body = JsonConvert.DeserializeObject<BlogData>(result.content);
                List<string> currentPages = new List<string>();
                pages = body.BlogDocument.Pages.ToList();
                posts = body.BlogDocument.Posts.ToList();
                currentUser = body.BlogDocument.UserDetails;
                foreach (PageData page in body.BlogDocument.Pages) currentPages.Add(page.Title);
                model = new BlogSettings
                (
                    body.BlogDocument.BlogDetails.Title,
                    body.BlogDocument.BlogDetails.LogoUrl,
                    body.BlogDocument.BlogDetails.Description,
                    body.BlogDocument.BlogDetails.PrimaryColor,
                    body.BlogDocument.BlogDetails.SecondaryColor,
                    body.BlogDocument.BlogDetails.BackgroundColor,
                    body.BlogDocument.Categories.ToList(),
                    currentPages.ToList(),
                    body.BlogDocument.BlogDetails.FacebookLink,
                    body.BlogDocument.BlogDetails.InstagramLink,
                    body.BlogDocument.BlogDetails.TwitterLink
                );
                ///getPageScreen
            }
            else
            {
                errorMessage = result.message;
                errorMessageType = Models.AlertMessageTypes.Error;
            }
        }
    }

    private async Task onDeleteClick()
    {
        var response = await _blogsRepo.deleteBlog(model.title);
        if (!response.isSuccess)
        {
            errorMessage = response.message;
            errorMessageType = Models.AlertMessageTypes.Error;
        }
        else
        {
            string[] url = model.logoUrl.Split('/');
            await _fileRepo.DeleteLogo(url[url.Length-1]);
            _navMan.NavigateTo("/");
        }
    }

    private string getPageScreen()
    {
        throw new NotImplementedException();
        /// get data of the page captured from main screen
    }

    private async Task formSubmit()
    {
        BlogDetails details = new BlogDetails
        {
            Title = model.title,
            LogoUrl = model.logoUrl,
            Description = model.description,
            PrimaryColor = model.primaryColor,
            SecondaryColor = model.secondaryColor,
            BackgroundColor = model.backgroundColor,
            FacebookLink = model.facebookLink,
            InstagramLink = model.instagramLink,
            TwitterLink = model.twitterLink
        };
        if (string.IsNullOrEmpty(title))
        {
            //new blog

            UserDetails user = new UserDetails
            {
                UserName = _userName+PasswordUtilities.CreatePassword(3),
                Password = PasswordUtilities.CreatePassword(6)
            };
            List<PageData> pages = new List<PageData>();
            foreach (string page in model.pages)
                pages.Add(new PageData
                {
                    Title = page,
                    ImageUrl = "./Assets/bg-5example.jpg",
                    Intro = "Default Page introduction",
                    Content = Utilities.Placeholders.dummyText,
                    Categories = new List<string>() { "Page" }.ToArray(),
                    Date = DateTime.Today.ToString("dd/mm/yyyy")
                });
            BlogDocument document = new BlogDocument
            {
                BlogDetails = details,
                UserDetails = user,
                Pages = pages.ToArray(),
                Categories = model.categories.ToArray(),
                Posts = new List<PageData>().ToArray()
            };
            BlogData data = new BlogData { BlogDocument = document };
            BlogRequestBody reqBody = new BlogRequestBody { UserEmail = _userName, data = data };
            var response = await _blogsRepo.postBlogData(reqBody);
            if (!response.isSuccess)
            {
                errorMessage = response.message;
                errorMessageType = Models.AlertMessageTypes.Error;
            }
            else _navMan.NavigateTo($"/blog-editor/all/{model.title}");
        }
        else
        {
            //existing
            List<PageData> pages = new List<PageData>();
            foreach (string page in model.pages)
                pages.Add(new PageData
                {
                    Title = page,
                    ImageUrl = "./Assets/bg-5example.jpg",
                    Intro = "Default Page introduction",
                    Content = Utilities.Placeholders.dummyText,
                    Categories = new List<string>() { "Page" }.ToArray(),
                    Date = DateTime.Today.ToString("dd/mm/yyyy")
                });
            BlogDocument document = new BlogDocument
            {
                BlogDetails = details,
                UserDetails = currentUser,
                Pages = pages.ToArray(),
                Categories = model.categories.ToArray(),
                Posts = posts.ToArray()
            };
            BlogData data = new BlogData { BlogDocument = document };
            BlogRequestBody reqBody = new BlogRequestBody { UserEmail = currentUser.UserName, data = data };
            var response = await _blogsRepo.updateBlogData(reqBody);
            if (!response.isSuccess)
            {
                errorMessage = response.message;
                errorMessageType = Models.AlertMessageTypes.Error;
            }
            else _navMan.NavigateTo($"/blog-editor/all/{model.title}");
        }
    }
    private async Task logoSend(InputFileChangeEventArgs e)
    {
        var maxAllowedFiles = 1;
        var format = "image/png";
        var file = e.GetMultipleFiles(maxAllowedFiles)[0];

        if (file.ContentType != format)
        {
            errorMessage = "File isn't in png format";
            errorMessageType = Models.AlertMessageTypes.Warning;
            return;
        }
        var result = await _fileRepo.UploadLogo(e.GetMultipleFiles(maxAllowedFiles)[0], format);

        if (result.isSuccess)
        {
            errorMessage = result.message;
            errorMessageType = Models.AlertMessageTypes.Success;
            model.logoUrl = result.content;
            return;
        }
        else
        {
            errorMessage = result.message;
            errorMessageType = Models.AlertMessageTypes.Error;
            return;
        }

    }
    private async void ValidateBlogTitle(string value)
    {
        var result = await _blogsRepo.checkIfExist(value);
        if (result.isSuccess)
        {
            if (result.content != "false" || string.IsNullOrWhiteSpace(value))
            {
                errorMessage = "Name Taken";
                errorMessageType = Models.AlertMessageTypes.Warning;
                return;
            }
            else
            {
                errorMessage = "Name valid";
                errorMessageType = Models.AlertMessageTypes.Success;
                return;
            }
        }
        else
        {
            errorMessage = result.message;
            errorMessageType = Models.AlertMessageTypes.Error;
            return;
        }
    }
    private void categoriesChanged(string value)
    {
        List<string> categories = value.Split(",").ToList();
        this.model.categories = categories;
    }
    private void pagesChanged(string value)
    {
        List<string> pages = value.Split(",").ToList();
        this.model.pages = pages;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlogsManagerRepository _blogsRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileManagerRepository _fileRepo { get; set; }
    }
}
#pragma warning restore 1591
