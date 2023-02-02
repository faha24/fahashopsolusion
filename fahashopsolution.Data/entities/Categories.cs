using fahashopsolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahashopsolution.Data.entities
{
    public class Categories
    {
        public int  id { set; get; }
        public int sortoder { set; get; }
        public bool isShowOnHome { set; get; }
        public int? parentid { set; get; }
        public Status status { set; get; }
        public List<ProductInCategories> ProductInCategories { set; get; }
    }
}
