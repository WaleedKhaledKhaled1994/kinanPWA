#pragma checksum "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f179e27b4414614e8841d7c38e2a6d1b5601aed0"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Pages.SubCategories
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SubCategories")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/SubCategories/index")]
    public partial class IndexSubCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __Blazor.PWA.Client.Pages.SubCategories.IndexSubCategory.TypeInference.CreateTelerikListView_0(__builder, 4, 5, 
#nullable restore
#line 11 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                           subCategories

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 11 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                   true

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 11 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                   5

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.OpenElement(9, "a");
                __builder2.AddAttribute(10, "href", "/subcategory/create");
                __builder2.AddAttribute(11, "style", "margin-left:20px;");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikButton>(12);
                __builder2.AddAttribute(13, "Icon", "add");
                __builder2.AddAttribute(14, "Class", "btn-primary");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "Add");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.AddMarkupContent(18, "<h3 style=\"text-align:center; color:black\">\r\n                Subcategories\r\n            </h3>");
            }
            , 19, (context) => (__builder2) => {
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "k-card k-card-horizontal");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "k-vbox k-column");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "k-card-body");
                __builder2.OpenElement(26, "h3");
                __builder2.AddAttribute(27, "class", "k-card-title");
                __builder2.AddAttribute(28, "style", "color:black");
                __builder2.AddContent(29, 
#nullable restore
#line 22 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                      context.Category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "h4");
                __builder2.AddAttribute(32, "class", "k-card-title");
                __builder2.AddAttribute(33, "style", "color:black");
                __builder2.AddContent(34, 
#nullable restore
#line 23 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                      context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "h5");
                __builder2.AddAttribute(37, "class", "k-card-subtitle");
                __builder2.AddAttribute(38, "style", "color:grey");
                __builder2.AddContent(39, 
#nullable restore
#line 24 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                        context.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "k-card-actions k-card-actions-horizontal k-card-actions-start");
                __builder2.OpenElement(43, "a");
                __builder2.AddAttribute(44, "href", "/subcategory/Edit/" + (
#nullable restore
#line 28 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                    context.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikButton>(45);
                __builder2.AddAttribute(46, "Icon", "edit");
                __builder2.AddAttribute(47, "Class", "btn-dark");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, "Edit");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                        &nbsp;&nbsp;\r\n                        ");
                __builder2.OpenComponent<PWA.Client.Shared.ConfirmButton>(51);
                __builder2.AddAttribute(52, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 30 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                  () => DeleteRow(@context.Id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(53, "ConfirmText", "Are you sure you want to delete this subcategory?");
                __builder2.AddAttribute(54, "ButtonText", "Delete");
                __builder2.AddAttribute(55, "ConfirmTitle", "Delete subcategory!");
                __builder2.AddAttribute(56, "Icon", "delete");
                __builder2.AddAttribute(57, "ButtonType", "btn-danger");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "img");
                __builder2.AddAttribute(60, "class", "k-card-image img-thumbnail");
                __builder2.AddAttribute(61, "alt", "SubCategory Image");
                __builder2.AddAttribute(62, "src", 
#nullable restore
#line 33 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                                      context.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(64);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
      
    private List<SubCategory> subCategories;

    protected override async Task OnInitializedAsync()
    {
        subCategories = await subCategoryRepository.GetSubCategories();
    }
    private async Task DeleteRow(int id)
    {
        await subCategoryRepository.DeleteSubCategory(id);
        subCategories = await subCategoryRepository.GetSubCategories();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISubCategory subCategoryRepository { get; set; }
    }
}
namespace __Blazor.PWA.Client.Pages.SubCategories.IndexSubCategory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikListView_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Int32 __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg4)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikListView<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Pageable", __arg1);
        __builder.AddAttribute(__seq2, "PageSize", __arg2);
        __builder.AddAttribute(__seq3, "HeaderTemplate", __arg3);
        __builder.AddAttribute(__seq4, "Template", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
