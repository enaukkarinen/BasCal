using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Darkside.WCF4Silverlight
{
    public class KalenteriService : IKalenteriService, IClientAccessPolicy
    {
        #region IService Members

        public int Add(int a, int b)
        {
            return (a + b);
        }
        #endregion

        #region IClientAccessPolicy Members

        [OperationBehavior]
        public Stream GetClientAccessPolicy()
        {
            const string result = @"<?xml version=""1.0"" encoding=""utf-8""?>
<access-policy>
    <cross-domain-access>
        <policy>
            <allow-from http-request-headers=""*"">
                <domain uri=""*""/>
            </allow-from>
            <grant-to>
                <resource path=""/"" include-subpaths=""true""/>
            </grant-to>
        </policy>
    </cross-domain-access>
</access-policy>";

            if (WebOperationContext.Current != null)
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/xml";
            return new MemoryStream(Encoding.UTF8.GetBytes(result));
        }

        #endregion

    }

}