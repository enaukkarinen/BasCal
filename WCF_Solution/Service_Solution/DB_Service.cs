using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DB_Solution;
using System.IO;
using System.ServiceModel.Web;

namespace Service_Solution
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DB_Service : IDB_Service, IClientAccessPolicy
    {
        dbRepository db = new dbRepository();

        #region DB_Service Members


        public List<string> FetchThroughClassLibAndFromDBAsString()
        {
            return db.FetchDataAsString();
        }

        public List<Testitaulu> FetchThroughClassLibAndFromDBAsTable()
        {
            return db.FetchDataAsTableModel().ToList();
        }

        #endregion

        #region Events

        public List<Event> FetchEvents()
        {
            var paluu = db.FetchEvents().ToList();
            return paluu;
        }

        #endregion


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

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
