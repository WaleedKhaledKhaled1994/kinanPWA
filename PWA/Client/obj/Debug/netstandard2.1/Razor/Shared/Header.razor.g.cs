#pragma checksum "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Shared\Header.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00b74240e1eede35c4220b8196ed83b00cd73d6e"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class Header : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "header-area");
            __builder.AddAttribute(2, "id", "headerArea");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container h-100 d-flex align-items-center justify-content-between");
            __builder.AddMarkupContent(5, "<div class=\"logo-wrapper\"><a href=\"home.html\"><img src=\"img/core-img/logo-small.png\" alt></a></div>\r\n        \r\n        ");
            __builder.AddMarkupContent(6, "<div class=\"top-search-form\"><form action=\"#\" method=\"POST\"><input class=\"form-control\" type=\"search\" placeholder=\"Enter your keyword\">\r\n                <button type=\"submit\"><i class=\"fa fa-search\"></i></button></form></div>\r\n        \r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "suha-navbar-toggler d-flex justify-content-between flex-wrap");
            __builder.AddAttribute(9, "id", "suhaNavbarToggler");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Shared\Header.razor"
                                                                                                                   NavbarToggler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "<span></span><span></span><span></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "sidenav-black-overlay");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Shared\Header.razor"
                                             SidenavBlackOverlay

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "suha-sidenav-wrapper");
            __builder.AddAttribute(19, "id", "sidenavWrapper");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(20);
            __builder.AddAttribute(21, "Roles", "Admin");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, @"<div class=""sidenav-profile""><div class=""user-profile""><img src=""img/bg-img/9.jpg"" alt></div>
            <div class=""user-info""><h6 class=""user-name mb-0"">Suha Jannat</h6>
                <p class=""available-balance"">Balance <span>$<span class=""counter"">379.23</span></span></p></div></div>
        
        ");
                __builder2.AddMarkupContent(24, @"<ul class=""sidenav-nav""><li><a href=""profile""><i class=""lni-user""></i>My Profile</a></li>
            <li><a href=""notifications.html""><i class=""lni-alarm lni-tada-effect""></i>Notifications<span class=""ml-3 badge badge-warning"">3</span></a></li>
            <li><a href=""pages.html""><i class=""lni-empty-file""></i>All Pages</a></li>
            <li><a href=""wishlist-grid.html""><i class=""lni-heart-filled""></i>My Wishlist</a></li>
            <li><a href=""settings""><i class=""lni-cog""></i>Settings</a></li>
            <li><a href=""logout""><i class=""lni-power-switch""></i>Sign Out</a></li></ul>
        
        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "go-home-btn");
                __builder2.AddAttribute(27, "id", "goHomeBtn");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Shared\Header.razor"
                                                          goHomeBtn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(29, "<i class=\"lni-arrow-left\"></i>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n  \r\n    \r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(31);
            __builder.AddAttribute(32, "Roles", "Waleed");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(34, "<div class=\"sidenav-profile\"><div class=\"user-info\"><h6 class=\"user-name mb-0 user-profile-name\">Admin Suha Jannat</h6></div></div>\r\n        \r\n        ");
                __builder2.AddMarkupContent(35, @"<ul class=""sidenav-nav""><li><a href=""profile""><i class=""lni-user""></i>My Profile</a></li>
            <li><a href=""profile""><i class=""lni-producthunt""></i>Products</a></li>
            <li><a href=""profile""><i class=""lni-package""></i>Orders</a></li>

            <li><a href=""profile""><i class=""lni-tag""></i>Subcategories</a></li>
            <li><a href=""profile""><i class=""lni-tab""></i>Categories</a></li>

            <li><a href=""profile""><i class=""lni-facebook-messenger lni-tada-effect""></i>Messages<span class=""ml-3 badge badge-warning"">15</span></a></li>

            <li><a href=""notifications.html""><i class=""lni-alarm lni-tada-effect""></i>Notifications<span class=""ml-3 badge badge-warning"">3</span></a></li>
            <li><a href=""pages.html""><i class=""lni-empty-file""></i>All Pages</a></li>

            <li><a href=""settings""><i class=""lni-cog""></i>Settings</a></li>
            <li><a href=""logout""><i class=""lni-power-switch""></i>Sign Out</a></li></ul>
        
        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "go-home-btn");
                __builder2.AddAttribute(38, "id", "goHomeBtn");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Shared\Header.razor"
                                                          goHomeBtn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(40, "<i class=\"lni-arrow-left\"></i>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Shared\Header.razor"
       
    protected async Task NavbarToggler()
    {
        await js.InvokeVoidAsync("NavbarToggler");
    }
    protected async Task goHomeBtn()
    {
        await js.InvokeVoidAsync("goHomeBtn");
    }
    protected async Task SidenavBlackOverlay()
    {
        await js.InvokeVoidAsync("SidenavBlackOverlay");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
