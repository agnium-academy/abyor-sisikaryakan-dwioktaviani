using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class golongan
    {
        public int kodeGolongan { get; set; }

        [Required]
        public string namaGolongan { get; set; }

        
    }
}