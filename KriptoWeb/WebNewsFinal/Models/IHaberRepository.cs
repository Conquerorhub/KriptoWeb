using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNewsFinal.Models
{
    public interface IHaberRepository
    {
        IQueryable<Haber> Habers { get; }
        void SaveHaber(Haber h);
        void UpdateHaber(Haber h);
        void CreateHaber(Haber h);
        void DeleteHaber(Haber h);
    }
}
