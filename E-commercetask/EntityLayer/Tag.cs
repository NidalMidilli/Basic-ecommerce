using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Tag
    {
        public int tagId { get; set; }
        public string name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
