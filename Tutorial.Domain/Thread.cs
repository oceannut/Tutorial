using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain
{
    /// <summary>
    /// 帖子。
    /// </summary>
    public class Thread : Message
    {

        public long FourmId { get; set; }

        public string Title { get; set; }

        public void Save(Forum forum, Action<Thread> action)
        {
            if (forum == null)
            {
                throw new ArgumentNullException();
            }
            if (forum.Id <= 0
                || string.IsNullOrWhiteSpace(Title)
                || string.IsNullOrWhiteSpace(this.Content)
                || string.IsNullOrWhiteSpace(Creator))
            {
                throw new InvalidOperationException();
            }
            this.FourmId = forum.Id;
            DateTime timeStamp = DateTime.Now;
            this.Creation = timeStamp;
            this.Modification = timeStamp;
            if (action != null)
            {
                action(this);
            }
        }

        public void Update(Action<Thread> action)
        {
            if (this.Id <= 0
                || string.IsNullOrWhiteSpace(this.Title)
                || string.IsNullOrWhiteSpace(this.Content))
            {
                throw new InvalidOperationException();
            }
            DateTime timeStamp = DateTime.Now;
            this.Modification = timeStamp;
            if (action != null)
            {
                action(this);
            }
        }

        public void SaveMessage(Message message, Action<Message> action)
        {
            if (this.Id <= 0)
            {
                throw new InvalidOperationException();
            }
            if (message == null)
            {
                throw new ArgumentNullException();
            }
            message.Save(this, action);
        }

        public long CountMessages(Func<Thread, long> action)
        {
            if (this.Id <= 0)
            {
                throw new InvalidOperationException();
            }
            return action == null ? 0 : action(this);
        }

        public IEnumerable<Message> ListMessages(Func<Thread, IEnumerable<Message>> action)
        {
            if (this.Id <= 0)
            {
                throw new InvalidOperationException();
            }
            return action == null ? new List<Message>() : action(this);
        }

    }

}
