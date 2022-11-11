using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }
        public int AddCategory(Category category)
        {
            return categoryDAL.Add(category);
        }

        public int DeleteCategory(Category category)
        {
            return categoryDAL.Delete(category);
        }

        public Category GetById(int id)
        {
            return categoryDAL.GetById(id);
        }

        public List<Category> ListAllCategory(Expression<Func<Category, bool>> filter = null)
        {

            return categoryDAL.ListAll();
        }

        public int UpdateCategory(Category category)
        {
            return categoryDAL.Update(category);
        }
    }
}
