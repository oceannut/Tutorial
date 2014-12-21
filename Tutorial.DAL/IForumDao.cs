using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tutorial.Domain;

namespace Tutorial.DAL
{
    public interface IForumDao
    {

        void Save(Forum forum);

        IList<Forum> List();

    }
}
