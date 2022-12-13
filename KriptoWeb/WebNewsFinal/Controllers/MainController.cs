using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebNewsFinal.Models;
using Newtonsoft.Json;

namespace WebNewsFinal.Controllers
{
    public class MainController : Controller
    {
        string apiUrl = "";
        IHaberRepository ctx;
        public MainController(IHttpContextAccessor httpContextAccessor,IHaberRepository ctx)
        {
            this.apiUrl = httpContextAccessor.HttpContext.Request.Host.Value.ToString();
            this.ctx = ctx;
            if (this.apiUrl.StartsWith("http"))
                apiUrl = @"https://" + this.apiUrl;
            if (this.apiUrl.IndexOf("http") == -1)
            {
                this.apiUrl = @"https://" + this.apiUrl;
            }
        }

        public async Task<ActionResult> Index()
        {
            List<Haber> haberler = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.ConnectionClose = true;

                HttpResponseMessage Res = await client.GetAsync("api/haberler");

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var HaberCevap = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    haberler = JsonConvert.DeserializeObject<List<Haber>>(HaberCevap);

                }
            }
            return View(haberler);
        }

        public async Task<ActionResult> Details(int id)
        {
            Haber haber = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.ConnectionClose = true;

                HttpResponseMessage Res = await client.GetAsync("api/haberler/" + id);

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var HaberCevap = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    haber = JsonConvert.DeserializeObject<Haber>(HaberCevap);

                }
            }
            return View("Detail", haber);
        }
        public IActionResult Haberler(int cateId=-1)
        {
            if(cateId!=-1)
            {
                return View(
                    ctx.Habers.Where(x => x.KategoriId==cateId)
                ) ;
            }
            return View(
                ctx.Habers.ToList()
            );
        }
    }
}
