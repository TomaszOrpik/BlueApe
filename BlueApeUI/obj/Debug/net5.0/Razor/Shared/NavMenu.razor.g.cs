#pragma checksum "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad139daa866aae9d157cd021f28c9a4931911ef"
// <auto-generated/>
#pragma warning disable 1591
namespace BlueApeUI.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "navigation");
            __builder.AddAttribute(2, "b-7azfw05dg0");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "nav flex-column");
            __builder.AddAttribute(5, "b-7azfw05dg0");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "nav-item");
            __builder.AddAttribute(8, "b-7azfw05dg0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "class", "nav-link");
            __builder.AddAttribute(11, "href", "/");
            __builder.AddAttribute(12, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 5 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "<img class=\"nav-link-body\" width=\"50\" height=\"50\" src=\"./Assets/Icons/selectBlogWhite.png\" b-7azfw05dg0>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
             if (String.IsNullOrEmpty(Title) || Title == "BlueApe Template")
            { }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "nav-item");
            __builder.AddAttribute(17, "b-7azfw05dg0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "nav-link");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 14 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
                                                     links[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
                                                                      NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "<img class=\"nav-link-body fixed\" width=\"40\" height=\"40\" src=\"./Assets/Icons/blogEditorWhite.png\" b-7azfw05dg0>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item");
            __builder.AddAttribute(27, "b-7azfw05dg0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 19 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
                                                     links[1]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
                                                                      NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "<img class=\"nav-link-body fixed\" width=\"40\" height=\"40\" src=\"./Assets/Icons/addPostWhite.png\" b-7azfw05dg0>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item");
            __builder.AddAttribute(37, "b-7azfw05dg0");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 24 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
                                                     links[2]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 24 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
                                                                      NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<img class=\"nav-link-body fixed\" width=\"40\" height=\"40\" src=\"./Assets/Icons/editPagesWhite.png\" b-7azfw05dg0>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.AddMarkupContent(45, @"<style b-7azfw05dg0>
    .navigation {
        width: 60px;
        height: 100vh;
        position: sticky;
        top: 0;
        background-color: #2f2f2f;
    }

    .nav-link {
        width: 50px;
        margin: 0px 5px;
        position: relative;
    }

    .nav-link-body {
        left: -2px;
        margin-left: 0;
        position: absolute;
    }
    .nav-link-body.fixed {
        left: 10px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Shared\NavMenu.razor"
       
    [Parameter]
    public string Title { get; set; }
    private List<string> links = new List<string>();

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        links.Add($"/blog-designer/{Title}");
        links.Add($"/blog-editor/{Title}");
        links.Add($"/page-selector/{Title}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591