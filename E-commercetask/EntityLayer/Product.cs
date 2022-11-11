using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int categoryId { get; set; }
        public DateTime createdat { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
