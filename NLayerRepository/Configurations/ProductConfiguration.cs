using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NLayerRepository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            //decimal 18,2 virgülden önce 18 virgülden sonra 2 karakter alabilsin maximum...
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID);
            //HasOne bir ürünün bir category si olabilir, WithMany bir categorynin birden fazla ürünü olabilir anlamındadır.
            //HasForeignKey ise ForeignKey olcak değeri belirtmek içindir.
            //EF Core un Foreign Key olarak algılayamayacağı isimler kullandığımız durumda kullanırız.

        }
    }
}
