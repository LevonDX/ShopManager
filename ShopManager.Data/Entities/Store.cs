using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Data.Entities
{
    public class Store : EntityBase
    {
        public Store()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; } = "";
        public string? Address { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}