using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNewsFinal.Models
{
    public class EFHaberRepository : IHaberRepository
    {
        public DataContext ctx;
        public IQueryable<Haber> Habers => ctx.Haberler;
        public EFHaberRepository(DataContext ctx)
        {
            this.ctx = ctx;
        }

        public void DeleteHaber(Haber h)
        {
            ctx.Remove(h);
            ctx.SaveChanges();
        }

       

        public void SaveHaber(Haber h)
        {
            ctx.SaveChanges();
        }

        public void UpdateHaber(Haber h)
        {
            ctx.Update(h);
            ctx.SaveChanges();
        }

        public void CreateHaber(Haber h)
        {
            ctx.Add(h);
            ctx.SaveChanges();
        }
    }
}
