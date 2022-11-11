using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        public int AddCategory(Category category);

        public int UpdateCategory(Category category);

        public int DeleteCategory(Category category);

        List<Category> ListAllCategory(Expression<Func<Category, bool>> filter = null);

        Category GetById(int id);
    }
}
