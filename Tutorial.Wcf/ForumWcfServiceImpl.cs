using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Tutorial.Domain;
using Tutorial.BLL;

namespace Tutorial.Wcf
{

    public class ForumWcfServiceImpl : IForumWcfService
    {

        internal IForumService ForumService { get; set; }

        public ForumWcfServiceImpl(IForumService forumService)
        {
            this.ForumService = forumService;
        }

        public Forum SaveForum(string name, string creator)
        {
            Forum forum = new Forum();
            forum.Name = name;
            forum.Creator = creator;
            forum.Save(
                (e) =>
                {
                    ForumService.SaveForum(e);
                });

            return forum;
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
            return ForumService.ListForum().ToArray();
        }
    }

}
