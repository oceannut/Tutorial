using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;

using Tutorial.Domain;
using Tutorial.DAL;
using Tutorial.DAL.Demo;
using Tutorial.BLL;
using Tutorial.BLL.Manager;

namespace Tutorial.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (IUnityContainer container = new UnityContainer())
            {
                container.RegisterType<IForumDao, ForumDao>();
                container.RegisterType<IForumService, ForumManager>();

                IForumService forumService = container.Resolve<IForumService>();
                var list = forumService.ListForum();
                foreach (var item in list)
                {
                    System.Console.WriteLine(item.Name);
                }
                System.Console.Read();
            }

        }
    }
}
