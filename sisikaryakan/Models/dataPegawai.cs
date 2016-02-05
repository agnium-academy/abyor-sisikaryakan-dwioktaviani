using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;

namespace sisikaryakan.Models
{
    public class dataPegawai
    {
        public int NIK { get; set; }

        [Required]
        public string namaPegawai { get; set; }

        [Required]
        public string tempatLahir { get; set; }

        [Required]
        public DateTime tanggalLahir { get; set; }

        [Required]
        public string alamat { get; set; }

        [Required]
        public Enum jenisKelamin { get; set; }

        [Required]
        public string noTelp { get; set; }

        [Required]
        public Enum status { get; set; }

        [Required]
        public jabatan kodeJabatan { get; set; }

        [HttpBindNever]
        public jabatan namaJabatan { get; set; }
    }
}