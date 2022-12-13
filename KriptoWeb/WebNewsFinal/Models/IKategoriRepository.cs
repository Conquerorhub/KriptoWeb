using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNewsFinal.Models
{
    public interface IKategoriRepository
    {
        IQueryable<Kategori> Kategories { get; }
        void SaveKategori(Kategori k);
        void UpdateKategori(Kategori k);
        void CreateKategori(Kategori k);
        void DeleteKategori(Kategori k);
    }
}
