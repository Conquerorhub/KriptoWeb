using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNewsFinal.Models
{
    public class EFKategoriRepository : IKategoriRepository
    {
        public DataContext ctx;
        public IQueryable<Kategori> Kategories => ctx.Kategoriler;

        public EFKategoriRepository(DataContext ctx)
        {
            this.ctx = ctx;
        }
        public void CreateKategori(Kategori k)
        {
            ctx.Kategoriler.Add(k);
            ctx.SaveChanges();
        }

        public void DeleteKategori(Kategori k)
        {
            ctx.Kategoriler.Remove(k);
            ctx.SaveChanges();
        }

        public void SaveKategori(Kategori k)
        {
            ctx.SaveChanges();
        }

        public void UpdateKategori(Kategori k)
        {
            ctx.Update(k);
            ctx.SaveChanges();
        }
    }
}
