#pragma checksum "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a76bd26a772749285e6dbf7844fed2cffcc6eb9"
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
    public partial class SubCategoryForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-content-wrapper");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "profile-wrapper-area py-3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card user-info-card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body p-4 d-flex align-items-center");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "user-info");
            __builder.OpenElement(12, "h3");
            __builder.AddContent(13, 
#nullable restore
#line 9 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                             Action

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " Subcategory");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card user-data-card");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(20);
            __builder.AddAttribute(21, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                     subCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                 onValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(24);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "<label>Category:</label>\r\n                            ");
                __builder2.OpenElement(29, "div");
                __Blazor.PWA.Client.Pages.SubCategories.SubCategoryForm.TypeInference.CreateTelerikComboBox_0(__builder2, 30, 31, 
#nullable restore
#line 21 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                                                      categories

#line default
#line hidden
#nullable disable
                , 32, "Select Category", 33, 
#nullable restore
#line 22 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                     nameof(Category.Name)

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 22 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                                                         nameof(Category.Id)

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 22 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                                                                                          true

#line default
#line hidden
#nullable disable
                , 36, "category", 37, 
#nullable restore
#line 21 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                       subCategory.CategoryId

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subCategory.CategoryId = __value, subCategory.CategoryId)), 39, () => subCategory.CategoryId);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label>Name:</label>\r\n                            ");
                __builder2.OpenElement(44, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                              subCategory.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subCategory.Name = __value, subCategory.Name))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => subCategory.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                                ");
                __Blazor.PWA.Client.Pages.SubCategories.SubCategoryForm.TypeInference.CreateValidationMessage_1(__builder2, 51, 52, 
#nullable restore
#line 31 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                          () => subCategory.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "<label>Description:</label>\r\n                            ");
                __builder2.OpenElement(57, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                              subCategory.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subCategory.Description = __value, subCategory.Description))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => subCategory.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                                ");
                __Blazor.PWA.Client.Pages.SubCategories.SubCategoryForm.TypeInference.CreateValidationMessage_2(__builder2, 64, 65, 
#nullable restore
#line 38 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                          () => subCategory.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.OpenComponent<PWA.Client.Shared.InputImg>(69);
                __builder2.AddAttribute(70, "Label", "Image");
                __builder2.AddAttribute(71, "OnSelectedImage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 42 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                     PictureSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(72, "ImageURL", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
                                                                                                 imageURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(74, "<button class=\"btn btn-success\" type=\"submit\">Save Changes</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\ENG\Desktop\PWA\PWA\PWA\Client\Pages\SubCategories\SubCategoryForm.razor"
       
    [Parameter] public SubCategory subCategory { get; set; }
    [Parameter] public string Action { get; set; }
    [Parameter] public EventCallback onValidSubmit { get; set; }
    private string imageURL;

    private List<Category> categories;

    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(subCategory.Image))
        {
            imageURL = subCategory.Image;
            subCategory.Image = null;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        categories = await categoryRepository.GetCategories();
    }

    private void PictureSelected(string imageBase64)
    {
        subCategory.Image = imageBase64;
        imageURL = null;
        Console.WriteLine(imageBase64);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategory categoryRepository { get; set; }
    }
}
namespace __Blazor.PWA.Client.Pages.SubCategories.SubCategoryForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikComboBox_0<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.String __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikComboBox<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "TextField", __arg2);
        __builder.AddAttribute(__seq3, "ValueField", __arg3);
        __builder.AddAttribute(__seq4, "Filterable", __arg4);
        __builder.AddAttribute(__seq5, "Id", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591