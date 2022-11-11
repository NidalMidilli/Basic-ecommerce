using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }

        public string categoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
