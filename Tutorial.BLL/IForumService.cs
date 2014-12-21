using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tutorial.Domain;

namespace Tutorial.BLL
{
    public interface IForumService
    {

        void SaveForum(Forum forum);

        void UpdateForum(Forum forum);

        void DeleteForum(long forumId);

        Forum GetForum(long forumId);

        long CountForum();

        IList<Forum> ListForum();

        void SaveThread(Thread thread);

        void UpdateThread(Thread thread);

        void DeleteThread(long threadId);

        Thread GetThread(long threadId);

        long CountThread(long forumId = 0);

        IList<Thread> ListThread(long forumId = 0);

        void SaveMessage(Message message);

        void UpdateMessage(Message message);

        void DeleteMessage(long messageId);

        Message GetMessage(long messageId);

        long CountMessage(long threadId = 0);

        IList<Message> ListMessage(long threadId = 0);

    }
}
