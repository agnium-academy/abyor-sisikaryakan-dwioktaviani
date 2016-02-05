using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class dataPegawai
    {
        public int NIK { get; set; }

        public string namaPegawai { get; set; }

        public string tempatLahir { get; set; }

        public DateTime tanggalLahir { get; set; }

        public string alamat { get; set; }

        public Enum jenisKelamin { get; set; }
    }
}