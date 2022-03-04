#pragma checksum "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f0ec3294af481e7298773df7439f855aac3badf"
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
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddAttribute(6, "colspan", "5");
            __builder.AddAttribute(7, "class", "text-center");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.AddContent(9, 
#nullable restore
#line 4 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
             TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n    ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\n");
#nullable restore
#line 9 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
         if (Shoppers?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
             foreach (Shopper s in Shoppers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 14 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                         s.FName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 15 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                         s.LName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 16 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                         s.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.AddMarkupContent(27, "<th>Book</th>\n                    ");
            __builder.AddMarkupContent(28, "<th>Quantity</th>\n\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddMarkupContent(30, "\n                        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                                                                          x=> OrderSelected.InvokeAsync(s.ShopperId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\n                            ");
            __builder.AddContent(35, 
#nullable restore
#line 22 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                             ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
#nullable restore
#line 27 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                 foreach (BasketLineItem bli in s.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                    ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "\n                        <td colspan=\"3\"></td>\n                        ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 31 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                             bli.Book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                        ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 32 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                             bli.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
#nullable restore
#line 34 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "            ");
            __builder.AddMarkupContent(51, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Orders</td>\n            </tr>\n");
#nullable restore
#line 42 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/OrderTable.razor"
       
    // Set the table title (Default: Ordered)
    [Parameter]
    public string TableTitle { get; set; } = "Ordered";

    // Get the Shopper records as an enumerable state
    [Parameter]
    public IEnumerable<Shopper> Shoppers { get; set; }

    // Set a button label (Default: Ship)
    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";

    // Declare callback function
    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
