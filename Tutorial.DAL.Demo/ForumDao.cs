using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

using Tutorial.Domain;
using Tutorial.DAL;

namespace Tutorial.DAL.Demo
{
    public class ForumDao : IForumDao
    {
        private readonly string filename = "F:\\forum.json";
        private readonly JavaScriptSerializer serializer = new JavaScriptSerializer();

        public void Save(Forum forum)
        {
            IList<Forum> list = List() ?? new List<Forum>();
            list.Add(forum);
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                string s = serializer.Serialize(list);
                byte[] data = Encoding.UTF8.GetBytes(s);
                fs.Write(data, 0, data.Length);
            }
        }

        public IList<Forum> List()
        {
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                return serializer.Deserialize<Forum[]>(Encoding.UTF8.GetString(data)).ToList();
            }
        }
    }
}
