#pragma checksum "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e010942d9c4a7e9131cfa1145fea922daac14f1e"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Pages.Products
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/subcategory/{SubCategoryId:int}")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
 if (Title != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PWA.Client.Shared.HeaderBack>(0);
            __builder.AddAttribute(1, "link", "/");
            __builder.AddAttribute(2, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                                 Title

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 8 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "top-products-area pt-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "<div class=\"section-heading d-flex align-items-center justify-content-between\"><h6 class=\"ml-1\">Flash Sale Products</h6></div>\r\n        ");
            __Blazor.PWA.Client.Pages.Products.Products.TypeInference.CreateGenericList_0(__builder, 8, 9, 
#nullable restore
#line 17 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                           products

#line default
#line hidden
#nullable disable
            , 10, (__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "product-catagory-wrap");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row");
#nullable restore
#line 21 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                         foreach (var item in products)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-6 col-sm-4");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "card flash-sale-card mb-3");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "card-body");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "href", "single-product.html");
                __builder2.OpenElement(23, "img");
                __builder2.AddAttribute(24, "src", 
#nullable restore
#line 28 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                                                       item.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(25, "alt", 
#nullable restore
#line 28 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                                                                         item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.OpenElement(26, "span");
                __builder2.AddAttribute(27, "class", "product-title");
                __builder2.AddContent(28, 
#nullable restore
#line 28 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                                                                                                                 item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                            ");
                __builder2.OpenElement(30, "span");
                __builder2.AddAttribute(31, "class", "progress-title");
                __builder2.AddContent(32, 
#nullable restore
#line 29 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                                                                          item.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                                            ");
                __builder2.OpenElement(34, "span");
                __builder2.AddAttribute(35, "class", "progress-title");
                __builder2.AddContent(36, 
#nullable restore
#line 30 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                                                                          item.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 37 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(38);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\Products\Products.razor"
       
    [Parameter] public int SubCategoryId { get; set; }
    private string Title;
    private SubCategory subcategory;
    private List<Product> products;

    protected override async Task OnInitializedAsync()
    {
        subcategory = await subCategoryRepository.GetSubCategory(SubCategoryId);
        Title = subcategory.Name;

        products = await productRepository.GetProductsBySubCategory(SubCategoryId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct productRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISubCategory subCategoryRepository { get; set; }
    }
}
namespace __Blazor.PWA.Client.Pages.Products.Products
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::PWA.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591