using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Models
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public int KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public Kategoriler Kategoriler { get; set; }
    }
}
