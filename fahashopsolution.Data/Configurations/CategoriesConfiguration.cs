using fahashopsolution.Data.entities;
using fahashopsolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahashopsolution.Data.Configurations
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {

            builder.ToTable("Categories");

            builder.HasKey(x => x.id);

            builder.Property(x => x.id).UseIdentityColumn();


            builder.Property(x => x.status).HasDefaultValue(Status.Active);
        }
    }
}
