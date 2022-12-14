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
#line 1 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\_Imports.razor"
using WebNewsFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/haberler/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/haberler/create")]
    public partial class Editor : OwningComponentBase<WebNewsFinal.Models.DataContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
       

    public WebNewsFinal.Models.DataContext Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;

    public Haber Haber { get; set; } = new Haber();

    protected override void OnParametersSet() {
        if (Id != 0) {
            Haber = Repository.Haberler.FirstOrDefault(h => h.HaberId == Id);
            kate_id = Haber.KategoriId.ToString();
        }
    }

    public void SaveProduct() {
        if (Id == 0) {
            long s = Haber.KategoriId;
            Haber.Kategori = Repository.Kategoriler.Where(x => x.KategoriId == s).FirstOrDefault();
            Haber.Kullanici = Repository.Kullanicilar.First();

            Repository.Add(Haber);
            Repository.SaveChanges();
        }
        else {
            Repository.Update(Haber);
            Repository.SaveChanges();
        }
        NavManager.NavigateTo("/admin/haberler");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Oluştur" : "Edit";
    public string kate_id { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
