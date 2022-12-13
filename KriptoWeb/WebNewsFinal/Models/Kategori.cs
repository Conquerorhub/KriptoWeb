using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebNewsFinal.Models
{
    public class Kategori
    {
        [Key]
        public long KategoriId { get; set; }
        public string baslik { get; set; }
        public ICollection<Haber> Haberler { get; set; }

    }
}
