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
    public class EventDataService : IEventDataService, IClientAccessPolicy
    {
        EventDataRepository db = new EventDataRepository();

        #region Events

        public UpcomingEventDTO FetchEventByGuid(Guid guid)
        {
            Event ev = db.FetchEventByGuid(guid);
            return ev.ToUpcomingEventDTO();         
        }

        public List<UpcomingEventShortDTO> FetchEventsByMonth(int m)
        {
            List<Event> evs = db.FetchEventsByMonth(m).ToList();
            List<UpcomingEventShortDTO> paluu = new List<UpcomingEventShortDTO>();

            foreach (Event ev in evs)
            {
                paluu.Add(ev.ToUpcomingEventShortDTO());
            }
            return paluu;
        }

        public List<UpcomingEventDTO> FetchUpcomingEvents()
        {
            List<Event> events = db.FetchEvents().ToList();
            List<UpcomingEventDTO> paluu = new List<UpcomingEventDTO>();
            foreach (Event e in events)
            {
                paluu.Add(e.ToUpcomingEventDTO());
            }
            return paluu;
        }

        public List<UpcomingEventShortDTO> FetchUpcomingEventsShort()
        {
            List<Event> evs = db.FetchEvents().ToList();
            List<UpcomingEventShortDTO> paluu = new List<UpcomingEventShortDTO>();

            foreach (Event ev in evs)
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