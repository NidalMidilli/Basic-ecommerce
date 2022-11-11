using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITagService
    {
        public int AddTag(Tag tag);

        public int UpdateTag(Tag tag);

        public int DeleteTag(Tag tag);

        List<Tag> ListAllTag(Expression<Func<User, bool>> filter = null);

        Tag GetById(int id);


    }
}
