using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        public int AddProduct(Product product);

        public int UpdateProduct(Product product);

        public int DeleteProduct(Product product);

        List<Product> ListAllProduct(Expression<Func<Product, bool>> filter = null);
        Product GetById(int id);
    }
}
