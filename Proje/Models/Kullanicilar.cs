using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Kullanicilar
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
