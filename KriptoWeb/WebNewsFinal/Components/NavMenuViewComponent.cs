using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNewsFinal.Models;

namespace WebNewsFinal.Components
{
    public class NavMenuViewComponent :  ViewComponent
    {
        private IKategoriRepository kategori;
        public NavMenuViewComponent(IKategoriRepository kategoriService)
        {
            kategori = kategoriService;
        }
        public IViewComponentResult Invoke()
        {
            return View(kategori.Kategories.ToList());
        }
    }
}
