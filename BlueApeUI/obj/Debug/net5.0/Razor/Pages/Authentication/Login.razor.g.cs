#pragma checksum "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba7675d7b11b7f29bd2b1c04b10e58df2bfebcf5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlueApeUI.Pages.Authentication
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
#line 4 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
using Models.Users.Requests;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-12");
            __builder.AddMarkupContent(4, "<h2 class=\"cardTitle\">Login to Your Account</h2>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                         model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                               LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(9);
                __builder2.AddAttribute(10, "class", "clearBorder");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlueApeUI.Shared.AlertMessage>(12);
                    __builder3.AddAttribute(13, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                        message

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "MessageType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlueApeUI.Models.AlertMessageTypes>(
#nullable restore
#line 14 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                                               messageType

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n                ");
                    __builder3.AddMarkupContent(20, "<label>Email</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(21);
                    __builder3.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                            model.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email))));
                    __builder3.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n                ");
                    __builder3.AddMarkupContent(26, "<label>Password</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(27);
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                             model.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                    __builder3.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n                <hr>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(32);
                    __builder3.AddAttribute(33, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 22 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                          Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "Text", "Login");
                    __builder3.AddAttribute(35, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 23 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                           Radzen.ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "class", "btn-block mr-2");
                    __builder3.AddAttribute(37, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(39);
                    __builder3.AddAttribute(40, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 25 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                          Radzen.ButtonType.Button

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Text", "Register");
                    __builder3.AddAttribute(42, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 26 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                           Radzen.ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "class", "btn-block mr-2");
                    __builder3.AddAttribute(44, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
                                                       GoToRegister

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\sycho\OneDrive\Desktop\BlueApe\BlueApeUI\Pages\Authentication\Login.razor"
       
    LoginEntity model = new LoginEntity();

    bool isBusy = false;
    string message = string.Empty;
    Models.AlertMessageTypes messageType = Models.AlertMessageTypes.Success;
    public async Task LoginUser()
    {
        isBusy = true;
        var result = await _authRepo.Login(model);
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            message = "User Logged Successfully";
            messageType = Models.AlertMessageTypes.Success;

            _navMan.NavigateTo("/");
        }
        else
        {
            message = result.Token;
            messageType = Models.AlertMessageTypes.Error;
        }
        isBusy = false;
    }

    void GoToRegister()
    {
        _navMan.NavigateTo("/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationRepository _authRepo { get; set; }
    }
}
#pragma warning restore 1591
