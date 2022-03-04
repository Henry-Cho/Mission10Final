#pragma checksum "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f946d9fed86e9d45e0f22b4e287119620fab82bb"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission10Final.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/_Imports.razor"
using Mission10Final.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"bg-info text-white p-2\">\n    <span class=\"navbar-brand m-lg-2\">Hilton\'s BookStore Administration</span>\n</div>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2 d-grid");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3");
            __builder.AddMarkupContent(9, "\n\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "d-grid gap-2");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "btn btn-outline-primary");
            __builder.AddAttribute(15, "href", "/admin/books");
            __builder.AddAttribute(16, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(17, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/AdminLayout.razor"
                                                                                                                         NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "\n                    Books\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "btn btn-outline-primary");
            __builder.AddAttribute(23, "href", "/admin/orders");
            __builder.AddAttribute(24, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(25, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/AdminLayout.razor"
                                                                                                                          NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(27, "Orders");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.AddMarkupContent(33, "\n            ");
            __builder.AddContent(34, 
#nullable restore
#line 21 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/AdminLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
