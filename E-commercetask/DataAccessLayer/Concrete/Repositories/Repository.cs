using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context con = new Context();
        DbSet<T> obj;

        public Repository()
        {
            obj = con.Set<T>();
        }
        public int Add(T ent)
        {
            obj.Add(ent);
            return con.SaveChanges();
        }

        public int Delete(T ent)
        {
            obj.Remove(ent);
            return con.SaveChanges();
        }

        public T GetById(int id)
        {
            return obj.Find(id);
        }

        public List<T> ListAll(Expression<Func<T, bool>> filter = null)
        {
            return obj.ToList();
        }

        public int Update(T ent)
        {
            obj.Update(ent);
            return con.SaveChanges();
        }
    }
}
