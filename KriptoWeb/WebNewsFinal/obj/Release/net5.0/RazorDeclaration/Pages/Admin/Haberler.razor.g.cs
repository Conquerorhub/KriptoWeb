// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebNewsFinal.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Emre YAZ\Desktop\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emre YAZ\Desktop\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emre YAZ\Desktop\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emre YAZ\Desktop\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emre YAZ\Desktop\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emre YAZ\Desktop\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using WebNewsFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/haberler")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Haberler : OwningComponentBase<WebNewsFinal.Models.DataContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Emre YAZ\Desktop\WebNewsFinal\WebNewsFinal\Pages\Admin\Haberler.razor"
       

    public WebNewsFinal.Models.DataContext Repository => Service;

    public IEnumerable<Haber> HaberData { get; set; }

    protected async override Task OnInitializedAsync() {
        await UpdateData();
    }

    public async Task UpdateData() {
        HaberData = await Repository.Haberler.ToListAsync();
    }

    public async Task DeleteProduct(Haber p) {
        Repository.Haberler.Remove(p);
        Repository.SaveChanges();
        await UpdateData();
    }

    public string GetDetailsUrl(long id) => $"/admin/haberler/details/{id}";
    public string GetEditUrl(long id) => $"/admin/haberler/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
