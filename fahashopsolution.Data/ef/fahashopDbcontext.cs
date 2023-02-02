using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fahashopsolution.Data.Configurations;
using fahashopsolution.Data.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Identity.Client;

namespace fahashopsolution.Data.ef
{
    public class FahashopDbcontext : DbContext
    {
        public FahashopDbcontext(DbContextOptions options) : base(options)
        {
          
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfigurations());
            modelBuilder.ApplyConfiguration(new ProductsConfigurations());
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Carts> Carts { get; set; }

        public DbSet<CategoriesTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductInCategories> ProductInCategories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }

        public DbSet<Promotion> Promotions { get; set; }


    }
}
