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
    internal class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x=>x.id).UseIdentityColumn();
            builder.HasOne(x=>x.Product).WithOne(x=>x.ProductFeature).HasForeignKey<ProductFeature>(x=>x.ProductID);
//Bire bir ilişki var ise bu şekilde tanımlanır.
        }
    }
}
