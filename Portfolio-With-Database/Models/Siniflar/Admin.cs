using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_With_Database.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public String KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}