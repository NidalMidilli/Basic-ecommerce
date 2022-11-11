using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            this.productDAL = productDAL;
        }
        public int AddProduct(Product product)
        {
            return productDAL.Add(product);
        }

        public int DeleteProduct(Product product)
        {
            return productDAL.Delete(product);
        }

        public Product GetById(int id)
        {
            return productDAL.GetById(id);
        }

        public List<Product> ListAllProduct(Expression<Func<Product, bool>> filter = null)
        {
            return productDAL.ListAll();
        }

        public int UpdateProduct(Product product)
        {
            return productDAL.Update(product);
        }
    }
}
