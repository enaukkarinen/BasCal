using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DB_Solution;
using BasCal_WCF_Host.DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using BasCal_WCF_Host.Extension;

namespace BasCal_WCF_Host
{
    public class DBservice : IDBservice, IClientAccessPolicy
    {
        dbRepository db = new dbRepository();

        #region Events

        public UpcomingEventDTO FetchEventByGuid(Guid guid)
        {
            Event ev = db.FetchEventByGuid(guid);
            return ev.ToUpcomingEventDTO();         
        }


        public List<UpcomingEventDTO> FetchUpcomingEvents()
        {
            return db.FetchEvents().Select(ev => ev.ToUpcomingEventDTO()).ToList();
        }

        public List<UpcomingEventShortDTO> FetchUpcomingEventsShort()
        {
            List<Event> jotain = db.FetchEvents().ToList();
            List<UpcomingEventShortDTO> paluu = new List<UpcomingEventShortDTO>();

            foreach (Event ev in jotain)
            {
                paluu.Add(ev.ToUpcomingEventShortDTO());
            }

            return paluu;
        }


        #endregion

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