using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain
{

    /// <summary>
    /// 消息。
    /// </summary>
    public class Message
    {

        public long Id { get; set; }

        public long ThreadId { get; set; }

        public string Content { get; set; }

        public string Creator { get; set; }

        public DateTime Creation { get; set; }

        public DateTime Modification { get; set; }

        public void Save(Thread thread, Action<Message> action)
        {
            if (thread == null)
            {
                throw new ArgumentNullException();
            }
            if (thread.Id <= 0
                || string.IsNullOrWhiteSpace(this.Content)
                || string.IsNullOrWhiteSpace(Creator))
            {
                throw new InvalidOperationException();
            }
            this.ThreadId = thread.Id;
            DateTime timeStamp = DateTime.Now;
            this.Creation = timeStamp;
            this.Modification = timeStamp;
            if (action != null)
            {
                action(this);
            }
        }

        public void Update(Action<Message> action)
        {
            if (this.Id <= 0
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

    }
}
