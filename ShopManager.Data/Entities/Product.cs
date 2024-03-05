using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Data.Entities
{
    public class Product : EntityBase
    {
        public Product()
        {
            Stores = new List<Store>();
        }

        public string Name { get; set; } = "";
        public string? Description { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
        public virtual Category? Category { get; set; }
    }
}