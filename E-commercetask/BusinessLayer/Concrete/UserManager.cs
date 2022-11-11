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
    public class UserManager : IUserService
    {
        IUserDAL userDAL;

        public UserManager(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }
        public int AddUser(User user)
        {
            return userDAL.Add(user);
        }

        public int DeleteUser(User user)
        {
            return userDAL.Delete(user);
        }

        public User GetById(int id)
        {
            return userDAL.GetById(id);
        }

        public List<User> ListAllUser(Expression<Func<User, bool>> filter = null)
        {
            return userDAL.ListAll();
        }

        public int UpdateUser(User user)
        {
            return userDAL.Update(user);
        }
    }
}
