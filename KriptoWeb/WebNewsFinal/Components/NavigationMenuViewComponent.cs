using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNewsFinal.Models;
using WebNewsFinal;
namespace WebNewsFinal.Components
{
    public class NavigationMenuViewComponent :ViewComponent
    {
        private IKategoriRepository kategori;
        
        public NavigationMenuViewComponent(IKategoriRepository kategoriService)
        {
            kategori = kategoriService;
        }
        public IViewComponentResult Invoke()
        {
            
            return View(kategori.Kategories.ToList());
        }
    }
}
