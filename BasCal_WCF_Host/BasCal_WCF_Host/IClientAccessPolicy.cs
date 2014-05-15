using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace BasCal_WCF_Host
{
    [ServiceContract]
    public interface IClientAccessPolicy
    {
        [OperationContract, WebGet(UriTemplate = "/clientaccesspolicy.xml")]
        Stream GetClientAccessPolicy();
    }
}