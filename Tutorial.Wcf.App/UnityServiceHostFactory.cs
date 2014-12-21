using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Activation;

using Microsoft.Practices.Unity;

using Tutorial.Unity;
using Tutorial.Wcf;
using Tutorial.BLL;
using Tutorial.BLL.Manager;
using Tutorial.DAL;
using Tutorial.DAL.Demo;

namespace Tutorial.Wcf.App
{
    public class UnityServiceHostFactory : ServiceHostFactory
    {
        private readonly IUnityContainer container;

        public UnityServiceHostFactory()
        {
            container = new UnityContainer();
            RegisterTypes(container);
        }

        protected override ServiceHost CreateServiceHost(
          Type serviceType, Uri[] baseAddresses)
        {
            return new UnityServiceHost(this.container,
              serviceType, baseAddresses);
        }

        private void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IForumDao, ForumDao>();
            container.RegisterType<IForumService, ForumManager>();
            container.RegisterType<IForumWcfService, ForumWcfServiceImpl>();
        }

    }
}