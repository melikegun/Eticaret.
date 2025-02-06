using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Eticaret.Data
{
    // : DbContext , entityframework kullanımı için
    public class DatabaseContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=MSI;
                Database=ETicaretDb;
                Trusted_Connection=True;
                TrustServerCertificate=True;
            ");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tüm entity'ler için konfigürasyonları otomatik olarak al
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // AppUser için CreateDate alanına varsayılan değer ekleyin
            modelBuilder.Entity<AppUser>()
                .Property(u => u.CreateDate)
                .HasDefaultValueSql("GETDATE()"); // SQL Server'da geçerli tarih

            // Diğer entity'ler için benzer işlemler yapılabilir
            modelBuilder.Entity<Brand>()
                .Property(p => p.CreateDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Product>()
                .Property(p => p.CreateDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Category>()
                .Property(p => p.CreateDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Contact>()
                .Property(p => p.CreateDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<News>()
                .Property(p => p.CreateDate)
                .HasDefaultValueSql("GETDATE()");


            base.OnModelCreating(modelBuilder);
        }


    }
}
