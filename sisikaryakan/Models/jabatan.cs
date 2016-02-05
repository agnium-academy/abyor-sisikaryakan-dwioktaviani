using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class jabatan
    {
        public int kodeJabatan { get; set; }

        [Required]
        public string namaJabatan { get; set; }
    }
}