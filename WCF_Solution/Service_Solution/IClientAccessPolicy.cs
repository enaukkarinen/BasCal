using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Service_Solution
{
    [ServiceContract]
    public interface IClientAccessPolicy
    {
        [OperationContract, WebGet(UriTemplate = "/clientaccesspolicy.xml")]
        Stream GetClientAccessPolicy();
    }
}