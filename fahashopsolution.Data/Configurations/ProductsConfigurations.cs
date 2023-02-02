using fahashopsolution.Data.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fahashopsolution.Data.Configurations
{
    public class ProductsConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Viewcount).IsRequired().HasDefaultValue((int)0);
            builder.Property(x => x.OriginalPrice).IsRequired();
        }
    }
}
