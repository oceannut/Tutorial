using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain
{

    /// <summary>
    /// 论坛。
    /// </summary>
    public class Forum
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public string Creator { get; set; }

        public DateTime Creation { get; set; }

        public DateTime Modification { get; set; }

        public void Save(Action<Forum> action)
        {
            if (string.IsNullOrWhiteSpace(this.Name)
               || string.IsNullOrWhiteSpace(Creator))
            {
                throw new InvalidOperationException();
            }
            DateTime timeStamp = DateTime.Now;
            this.Creation = timeStamp;
            this.Modification = timeStamp;
            if (action != null)
            {
                action(this);
            }
        }

        public void Update(Action<Forum> action)
        {
            if (this.Id <= 0
                || string.IsNullOrWhiteSpace(this.Name))
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

        public void SaveThread(Thread thread, Action<Thread> action)
        {
            if (this.Id <= 0)
            {
                throw new InvalidOperationException();
            }
            if (thread == null)
            {
                throw new ArgumentNullException();
            }
            thread.Save(this, action);
        }

        public long CountThreads(Func<Forum, long> action)
        {
            if (this.Id <= 0)
            {
                throw new InvalidOperationException();
            }
            return action == null ? 0 : action(this);
        }

        public IEnumerable<Thread> ListThreads(Func<Forum, IEnumerable<Thread>> action)
        {
            if (this.Id <= 0)
            {
                throw new InvalidOperationException();
            }
            return action == null ? new List<Thread>() : action(this);
        }

    }

}
