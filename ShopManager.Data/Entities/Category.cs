using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Data.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; } = "";

        public virtual ICollection<Product> Products { get; set; }
    }
}
