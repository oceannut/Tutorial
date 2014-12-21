using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

using Tutorial.Domain;
using Tutorial.BLL;

namespace Tutorial.Client.ServiceAdapter.Rest
{
    public class ForumServiceAdapter : IForumService
    {

        private readonly JavaScriptSerializer serializer = new JavaScriptSerializer();

        public void SaveForum(Forum forum)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.UploadStringCompleted +=
                (o, e) =>
                {
                };
            string url = "ForumnService.svc/forum/0/";
            client.UploadStringAsync(new Uri(url), serializer.Serialize(forum));
        }

        public void UpdateForum(Forum forum)
        {
            throw new NotImplementedException();
        }

        public void DeleteForum(long forumId)
        {
            throw new NotImplementedException();
        }

        public Forum GetForum(long forumId)
        {
            throw new NotImplementedException();
        }

        public long CountForum()
        {
            throw new NotImplementedException();
        }

        public IList<Forum> ListForum()
        {
            throw new NotImplementedException();
        }

        public void SaveThread(Thread thread)
        {
            throw new NotImplementedException();
        }

        public void UpdateThread(Thread thread)
        {
            throw new NotImplementedException();
        }

        public void DeleteThread(long threadId)
        {
            throw new NotImplementedException();
        }

        public Thread GetThread(long threadId)
        {
            throw new NotImplementedException();
        }

        public long CountThread(long forumId = 0)
        {
            throw new NotImplementedException();
        }

        public IList<Thread> ListThread(long forumId = 0)
        {
            throw new NotImplementedException();
        }

        public void SaveMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public void UpdateMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public void DeleteMessage(long messageId)
        {
            throw new NotImplementedException();
        }

        public Message GetMessage(long messageId)
        {
            throw new NotImplementedException();
        }

        public long CountMessage(long threadId = 0)
        {
            throw new NotImplementedException();
        }

        public IList<Message> ListMessage(long threadId = 0)
        {
            throw new NotImplementedException();
        }
    }
}
