using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Kategoriler
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public virtual List<Urun> MyProperty { get; set; }

    }
}
