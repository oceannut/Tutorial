using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Tutorial.Domain;

namespace Tutorial.Wcf.Rest
{
  
    [ServiceContract]
    public interface IForumWcfService
    {

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/forum/0/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Forum SaveForum(string name, string creator);

        [OperationContract]
        [WebInvoke(Method = "PUT",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/forum/{id}/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Forum UpdateForum(string id, string name);

        [WebInvoke(Method = "DELETE",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/forum/{id}/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        void DeleteForum(string id);

        [WebGet(UriTemplate = "/forum/{id}/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Forum GetForum(string id);

        [WebGet(UriTemplate = "/forum/count/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        long CountForum();

        [WebGet(UriTemplate = "/forum/list/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Forum[] ListForum();

    }

}
