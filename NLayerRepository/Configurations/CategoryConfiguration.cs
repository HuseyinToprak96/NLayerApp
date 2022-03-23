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
    internal class CategoryConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)//Category nin implementi..
        {
           builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();//İdentity yapmak için kullanılır. değer belirlemezsek 1 1 artar
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);//
            //IsRequired=Null olamaz
            //HasMaxLength(50)=Max 50 karakter alabilir anlamındadır.
            //builder.ToTable("")//VeriTabanında Tablo ismini değiştirmek için kullanılır.
            
        }
    }
}
