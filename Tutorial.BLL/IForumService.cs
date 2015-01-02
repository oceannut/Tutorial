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

        Task SaveForumAsync(Forum forum);

        void UpdateForum(Forum forum);

        Task UpdateForumAsync(Forum forum);

        void DeleteForum(long forumId);

        Task DeleteForumAsync(long forumId);

        Forum GetForum(long forumId);

        Task<Forum> GetForumAsync(long forumId);

        long CountForum();

        Task<long> CountForumAsync();

        IList<Forum> ListForum();

        Task<IList<Forum>> ListForumAsync();

        void SaveThread(Thread thread);

        Task SaveThreadAsync(Thread thread);

        void UpdateThread(Thread thread);

        Task UpdateThreadAsync(Thread thread);

        void DeleteThread(long threadId);

        Task DeleteThreadAsync(long threadId);

        Thread GetThread(long threadId);

        Task<Thread> GetThreadAsync(long threadId);

        long CountThread(long forumId = 0);

        Task<long> CountThreadAsync(long forumId = 0);

        IList<Thread> ListThread(long forumId = 0);

        Task<IList<Thread>> ListThreadAsync(long forumId = 0);

        void SaveMessage(Message message);

        Task SaveMessageAsync(Message message);

        void UpdateMessage(Message message);

        Task UpdateMessageAsync(Message message);

        void DeleteMessage(long messageId);

        Task DeleteMessageAsync(long messageId);

        Message GetMessage(long messageId);

        Task<Message> GetMessageAsync(long messageId);

        long CountMessage(long threadId = 0);

        Task<long> CountMessageAsync(long threadId = 0);

        IList<Message> ListMessage(long threadId = 0);

        Task<IList<Message>> ListMessageAsync(long threadId = 0);

    }
}
