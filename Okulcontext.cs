using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeodev
{
    public class OkulContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersleri { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;Database=OkulOdev;Trusted_Connection=True; TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.Sinif)
                .WithMany(s => s.Ogrenciler)
                .HasForeignKey(o => o.SinifId)
                .OnDelete(DeleteBehavior.Restrict); 

            
            modelBuilder.Entity<OgrenciDers>()
                .HasKey(od => new { od.OgrenciId, od.DersId });

            
            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.OgrenciDersleri)
                .HasForeignKey(od => od.OgrenciId);

            
            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ders)
                .WithMany(d => d.OgrenciDersleri)
                .HasForeignKey(od => od.DersId);

            
            modelBuilder.Entity<Sinif>().HasData(
                new Sinif { SinifId = 1, Adi = "1. Sınıf", Kapasite = 10 },
                new Sinif { SinifId = 2, Adi = "2. Sınıf", Kapasite = 10 },
                new Sinif { SinifId = 3, Adi = "3. Sınıf", Kapasite = 10 }
            );

            
            modelBuilder.Entity<Ders>().HasData(
                new Ders { DersId = 1, Baslik = "Veri Tabanı" },
                new Ders { DersId = 2, Baslik = "Görsel Programlama" },
                new Ders { DersId = 3, Baslik = "Nesne Tabanlı Programlama" },
                new Ders { DersId = 4, Baslik = "İngilizce" },
                new Ders { DersId = 5, Baslik = "İnternet Programcılığı" },
                new Ders { DersId = 6, Baslik = "E Ticaret" },
                new Ders { DersId = 7, Baslik = "Sosyal Medya Ve Reklam" },
                new Ders { DersId = 8, Baslik = "Kalite Güvence Standart" },
                new Ders { DersId = 9, Baslik = "İş Sağlığı Güvenliği" },
                new Ders { DersId = 10, Baslik = "Zaman Yönetimi" }
            );
        }
    }
}
