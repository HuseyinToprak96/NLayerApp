using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerCore;
using System.Reflection;

namespace NLayerRepository
{
   public class AppDbContext:DbContext//DbContext ten türer.
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            //startUp dosyasından ConnectionString verebilmek için..kullanılır
        }
        //Her DbSet için bir property oluşturulur.
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> Categories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        //ProductFeature u istersek Product üzerinden ekleyebiliriz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Model oluşurken çalışacak olan Metot!!!
            //Örneğin bir modele id verecek isek ve 
            // modelBuilder.Entity<Category>().HasKey(x => x.Id);
            //Bu kısmında temiz kalması gerektiğinden ayrı classda yapılması daha doğrudur.
            //NLayerRepository içinde bulunan Configurations adındaki klasörün içerisine her tablo için bir Configurations oluşturmak gerekir.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//IEntityTypeConfiguration implement eden bütün sınıfları okur..
                                                                                          //Assembly için using System.Reflection; eklenmelidir.

            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            { 
            Id=1,
            Color="Kırmızı",
            Height=100,
            Width=200
            });//Best Pracrices açısından buraya yazmak doğru değildir. Fakat yazılabilmektedir.

            
            base.OnModelCreating(modelBuilder); 
        }
    }
}
