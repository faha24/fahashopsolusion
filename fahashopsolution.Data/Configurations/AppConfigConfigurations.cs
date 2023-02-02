using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fahashopsolution.Data.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fahashopsolution.Data.Configurations
{
    public class AppConfigConfigurations : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
           builder.HasKey((x) => x.Key);
            builder.Property((x) => x.Value).IsRequired(true);

            
        }
    }
}
