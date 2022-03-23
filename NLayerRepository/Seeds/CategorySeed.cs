using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NLayerRepository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //idleri seed değer verirken kendi elimizle girmemiz gerekir.
           // Category c = new();//Core 6 dan itibaren instance bu şekilde alınabilmektedir.

            //builder.HasData(
            //    new Category { Id=1, Name="Kalemler" },
            //    new Category { Id = 2, Name = "Defterler" },
            //    new Category { Id = 3, Name = "Kitaplar" });
      
        }
    }
}
