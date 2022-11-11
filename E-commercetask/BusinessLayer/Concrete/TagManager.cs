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
    public class TagManager : ITagService
    {
        ITagDAL tagDAL;

        public TagManager(ITagDAL tagDAL)
        {
            this.tagDAL = tagDAL;
        }
        public int AddTag(Tag tag)
        {
            return tagDAL.Add(tag);
        }

        public int DeleteTag(Tag tag)
        {
            return tagDAL.Delete(tag);
        }

        public Tag GetById(int id)
        {
            return tagDAL.GetById(id);
        }

        public List<Tag> ListAllTag(Expression<Func<User, bool>> filter = null)
        {
            return tagDAL.ListAll();
        }

        public int UpdateTag(Tag tag)
        {
            return tagDAL.Update(tag);
        }
    }
}
