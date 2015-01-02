﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tutorial.Domain;
using Tutorial.BLL;
using Tutorial.Client.ServiceAdapter.ForumWcfService;

namespace Tutorial.Client.ServiceAdapter
{
    public class ForumServiceAdapter : IForumService
    {

        public void SaveForum(Forum forum)
        {
            var client = new ForumWcfServiceClient();
            client.SaveForum(forum.Name, forum.Creator);
        }

        public Task SaveForumAsync(Forum forum)
        {
            var client = new ForumWcfServiceClient();
            return client.SaveForumAsync(forum.Name, forum.Creator);
        }

        public void UpdateForum(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumAsync(Forum forum)
        {
            throw new NotImplementedException();
        }

        public void DeleteForum(long forumId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteForumAsync(long forumId)
        {
            throw new NotImplementedException();
        }

        public Forum GetForum(long forumId)
        {
            throw new NotImplementedException();
        }

        public Task<Forum> GetForumAsync(long forumId)
        {
            throw new NotImplementedException();
        }

        public long CountForum()
        {
            throw new NotImplementedException();
        }

        public Task<long> CountForumAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Forum> ListForum()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Forum>> ListForumAsync()
        {
            throw new NotImplementedException();
        }

        public void SaveThread(Thread thread)
        {
            throw new NotImplementedException();
        }

        public Task SaveThreadAsync(Thread thread)
        {
            throw new NotImplementedException();
        }

        public void UpdateThread(Thread thread)
        {
            throw new NotImplementedException();
        }

        public Task UpdateThreadAsync(Thread thread)
        {
            throw new NotImplementedException();
        }

        public void DeleteThread(long threadId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteThreadAsync(long threadId)
        {
            throw new NotImplementedException();
        }

        public Thread GetThread(long threadId)
        {
            throw new NotImplementedException();
        }

        public Task<Thread> GetThreadAsync(long threadId)
        {
            throw new NotImplementedException();
        }

        public long CountThread(long forumId = 0)
        {
            throw new NotImplementedException();
        }

        public Task<long> CountThreadAsync(long forumId = 0)
        {
            throw new NotImplementedException();
        }

        public IList<Thread> ListThread(long forumId = 0)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Thread>> ListThreadAsync(long forumId = 0)
        {
            throw new NotImplementedException();
        }

        public void SaveMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public Task SaveMessageAsync(Message message)
        {
            throw new NotImplementedException();
        }

        public void UpdateMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMessageAsync(Message message)
        {
            throw new NotImplementedException();
        }

        public void DeleteMessage(long messageId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMessageAsync(long messageId)
        {
            throw new NotImplementedException();
        }

        public Message GetMessage(long messageId)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetMessageAsync(long messageId)
        {
            throw new NotImplementedException();
        }

        public long CountMessage(long threadId = 0)
        {
            throw new NotImplementedException();
        }

        public Task<long> CountMessageAsync(long threadId = 0)
        {
            throw new NotImplementedException();
        }

        public IList<Message> ListMessage(long threadId = 0)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Message>> ListMessageAsync(long threadId = 0)
        {
            throw new NotImplementedException();
        }

    }
}
