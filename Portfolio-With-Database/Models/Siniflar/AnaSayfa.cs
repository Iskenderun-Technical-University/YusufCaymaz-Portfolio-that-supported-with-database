using System.ComponentModel.DataAnnotations;

namespace Portfolio_With_Database.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Iletisim { get; set; }
    }
}