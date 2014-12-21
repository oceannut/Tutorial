using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Tutorial.Domain;

namespace Tutorial.Wcf
{
  
    [ServiceContract]
    public interface IForumWcfService
    {

        [OperationContract]
        Forum SaveForum(string name, string creator);

        [OperationContract]
        Forum UpdateForum(string id, string name);

        [OperationContract]
        void DeleteForum(string id);

        [OperationContract]
        Forum GetForum(string id);

        [OperationContract]
        long CountForum();

        [OperationContract]
        Forum[] ListForum();

    }

}
