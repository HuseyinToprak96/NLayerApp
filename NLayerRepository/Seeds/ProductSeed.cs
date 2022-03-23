using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerCore;
namespace NLayerRepository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //idleri seed değer verirken kendi elimizle girmemiz gerekir.
            // Category c = new();//Core 6 dan itibaren instance bu şekilde alınabilmektedir.

            //builder.HasData(
            //    new Product { Id = 1, CategoryID=  1, Price=100, Stock=20,CreatedDate=DateTime.Now, Name = "Kalem 1" },
            //    new Product { Id = 2, CategoryID = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now, Name = "Kalem 2" },
            //    new Product { Id = 3, CategoryID = 2, Price = 100, Stock = 20, CreatedDate = DateTime.Now, Name = "Defter 1" },
            //    new Product { Id = 4, CategoryID = 2, Price = 100, Stock = 20, CreatedDate = DateTime.Now, Name = "Defter 2" });

        }
    }
}
