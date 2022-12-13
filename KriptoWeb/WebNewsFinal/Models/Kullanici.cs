using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebNewsFinal.Models
{
    public class Kullanici
    {
        [Key]
        public long KullaniciId { get; set; }
        public string kullaniciAdi { get; set; }
        public string eposta { get; set; }
        public string sifre { get; set; }
        public string avatar { get; set; }
        public bool admin_mi { get; set; }
        public ICollection<Haber> Haberler { get; set; }

    }
}
