using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Models
{
    public class Adres
    {
        public int Id { get; set; }
        public string AcikAdres{ get; set; }
        public int KullaniciId { get; set; }
        [ForeignKey("KullaniciId")]
        public Kullanicilar Kullanici { get; set; }
    }
}
