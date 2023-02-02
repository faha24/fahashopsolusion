using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahashopsolution.Data.entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int Viewcount { set; get; }
        public DateTime Datecreated { set; get; }
        public string SeoAlias { set; get; }
        public List<ProductInCategories> ProductInCategories { get; set; }
    }
}
