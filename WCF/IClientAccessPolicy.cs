using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Darkside.WCF4Silverlight
{
    [ServiceContract]
    public interface IClientAccessPolicy
    {
        [OperationContract, WebGet(UriTemplate = "/clientaccesspolicy.xml")]
        Stream GetClientAccessPolicy();
    }
}