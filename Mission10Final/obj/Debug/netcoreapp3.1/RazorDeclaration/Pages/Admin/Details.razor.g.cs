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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/Users/hyungseokcho/Projects/Mission10Final/Mission10Final/Pages/Admin/Details.razor"
       
    // Inject a Book repository
    [Inject]
    public IBookRepository repo { get; set; }

    // Id passed through the url
    [Parameter]
    public long Id { get; set; }

    // A book info
    public Book b { get; set; }

    // On parameter set
    protected override void OnParametersSet()
    {
        b = repo.Books.FirstOrDefault(x => x.BookID == Id);
    }

    // Set a Edit url
    public string EditUrl => $"/admin/books/detailsedit/{Id}";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
