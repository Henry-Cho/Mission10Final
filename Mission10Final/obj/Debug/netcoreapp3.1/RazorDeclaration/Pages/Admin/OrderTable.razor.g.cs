// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
