using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebNewsFinal.Models
{
    public class Haber
    {
        [Key]
        public long HaberId { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }
        public string kisa_icerik { get; set; }
        public string kapak_foto {get; set; }
        public DateTime yayin_tarihi { get; set; } = DateTime.Now;
        public long KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public long KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

    }
}
