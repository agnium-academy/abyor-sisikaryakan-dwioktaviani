using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace sisikaryakan.Models
{
    public class tunjangan
    {
        public int kodeTunjuangan { get; set; }

        [Required]
        public string namaTunjangan { get; set; }

        [Required]
        public int biaya { get; set; }

        [Required]
        public golongan kodeGolongan { get; set; }

        [HttpBindNever]
        public golongan namaGolongan { get; set;  }


    }
}