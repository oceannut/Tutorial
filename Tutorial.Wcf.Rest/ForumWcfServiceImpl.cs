using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Tutorial.Domain;
using Tutorial.BLL;

namespace Tutorial.Wcf.Rest
{

    public class ForumWcfServiceImpl : IForumWcfService
    {

        internal IForumService ForumService { get; set; }

        public Forum SaveForum(string name, string creator)
        {
            throw new NotImplementedException();
        }

        public Forum UpdateForum(string id, string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteForum(string id)
        {
            throw new NotImplementedException();
        }

        public Forum GetForum(string id)
        {
            throw new NotImplementedException();
        }

        public long CountForum()
        {
            throw new NotImplementedException();
        }

        public Forum[] ListForum()
        {
            throw new NotImplementedException();
        }
    }

}
