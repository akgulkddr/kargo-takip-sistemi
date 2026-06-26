using KargoTakipSistemi1.Models;
using Microsoft.EntityFrameworkCore;

namespace KargoTakipSistemi1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sube> Subeler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Kargo> Kargolar { get; set; }
        public DbSet<DurumKaydi> DurumKayitlari { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kargo>()
                .HasOne(k => k.Gonderici)
                .WithMany(m => m.GonderilenKargolar)
                .HasForeignKey(k => k.GondericiId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Kargo>()
                .HasOne(k => k.Alici)
                .WithMany(m => m.AlinanKargolar)
                .HasForeignKey(k => k.AliciId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Kargo>()
                .HasOne(k => k.CikisSube)
                .WithMany(s => s.CikisKargolari)
                .HasForeignKey(k => k.CikisSubeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Kargo>()
                .HasOne(k => k.VarisSube)
                .WithMany(s => s.VarisKargolari)
                .HasForeignKey(k => k.VarisSubeId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }


}
