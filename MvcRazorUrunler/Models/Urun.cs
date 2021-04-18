using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRazorUrunler.Models
{

    public class Urun
    {
        public int Id { get; set; }

        [Required,StringLength(30)]
        public string UrunAd { get; set; }

        [Required]
        public decimal BirimFiyat { get; set; }
    }
}
