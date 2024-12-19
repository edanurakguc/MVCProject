using Microsoft.EntityFrameworkCore;

namespace Proje.Models
{
    public class productdb : DbContext
    {
        public productdb(DbContextOptions<productdb> options) : base(options)
        {
        }

        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Adres> Adres { get; set; }
        

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Kullanici>().ToTable("Users");
        //    modelBuilder.Entity<Kategori>().ToTable("Categories");
        //    modelBuilder.Entity<Urun>().ToTable("Product");
        //}
    }
}
