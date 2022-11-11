using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        public int AddUser(User user);

        public int UpdateUser(User user);

        public int DeleteUser(User user);

        List<User> ListAllUser(Expression<Func<User, bool>> filter = null);

        User GetById(int id);
    }
}
