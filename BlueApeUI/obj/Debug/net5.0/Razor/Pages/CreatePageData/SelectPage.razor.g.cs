#pragma checksum "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreatePageData\SelectPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bce97aa79868f58522e45a47efeae38524885ab3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlueApeUI.Pages.CreatePageData
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/page-selector")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/page-selector/{Title}")]
    public partial class SelectPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SelectPage</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\CreatePageData\SelectPage.razor"
       
    [Parameter]
    public string Title { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
