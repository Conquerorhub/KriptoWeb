#pragma checksum "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c8121fb1fcb6fdd1f467ebb922b4d05543a2ffc"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<style>\n    div.validation-message { color: rgb(220, 53, 69); font-weight: 500 }\n</style>\n\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "admin-page-title");
            __builder.AddContent(3, "Haber ");
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                    TitleText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "admin-form-wrapper");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                 Haber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                       SaveProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
#nullable restore
#line 13 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
     if (Haber.HaberId != 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label>ID</label>\n    ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "disabled");
                __builder2.AddAttribute(19, "value", 
#nullable restore
#line 17 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                                 Haber.HaberId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 18 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
      }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label>Haber Başlığı</label>\n        ");
                __Blazor.WebNewsFinal.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 21 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                  () => Haber.baslik

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(25, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                                     Haber.baslik

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Haber.baslik = __value, Haber.baslik))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Haber.baslik));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label>İçerik</label>\n        ");
                __Blazor.WebNewsFinal.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 26 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                  () => Haber.icerik

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(38);
                __builder2.AddAttribute(39, "class", "form-control admin-text-area");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                                                         Haber.icerik

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Haber.icerik = __value, Haber.icerik))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Haber.icerik));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "<label>Kategori</label>\n        ");
                __Blazor.WebNewsFinal.Pages.Admin.Editor.TypeInference.CreateInputSelect_2(__builder2, 47, 48, "form-control show-tick", 49, 
#nullable restore
#line 31 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                                                 Haber.KategoriId

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Haber.KategoriId = __value, Haber.KategoriId)), 51, () => Haber.KategoriId, 52, (__builder3) => {
#nullable restore
#line 32 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
             foreach (var item in Repository.Kategoriler)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 34 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                item.KategoriId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(55, 
#nullable restore
#line 34 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                                  item.baslik

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 35 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "<label>Resim</label>\n        ");
                __Blazor.WebNewsFinal.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 60, 61, 
#nullable restore
#line 40 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                  () => Haber.kapak_foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(62, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                                     Haber.kapak_foto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Haber.kapak_foto = __value, Haber.kapak_foto))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Haber.kapak_foto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n        ");
                __builder2.OpenElement(69, "img");
                __builder2.AddAttribute(70, "src", 
#nullable restore
#line 42 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                   Haber.kapak_foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(71, "style", "max-height: 300px;");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n\n    ");
                __builder2.OpenElement(73, "button");
                __builder2.AddAttribute(74, "type", "submit");
                __builder2.AddAttribute(75, "class", "btn" + " btn-" + (
#nullable restore
#line 45 "C:\Users\fthal\OneDrive\Masaüstü\WebNewsFinal\WebNewsFinal\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(76, "Ekle");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(78);
                __builder2.AddAttribute(79, "class", "btn btn-secondary");
                __builder2.AddAttribute(80, "href", "/admin/haberler");
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(82, "İptal");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
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
namespace __Blazor.WebNewsFinal.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
