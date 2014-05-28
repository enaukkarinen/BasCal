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
            return db.FetchEventByGuid(guid).ToUpcomingEventDTO();         
        }

        public string AddOrUpdateEvent(UpcomingEventDTO uev)
        {
                return db.UpdateOrAddEvent(uev.ToEvent());
        }

        public List<UpcomingEventShortDTO> FetchEventsByMonth(int m)
        {
            return db.FetchEventsByMonth(m).ToList().Select(e => e.ToUpcomingEventShortDTO()).ToList();
        }

        public List<UpcomingEventShortDTO> FetchUpcomingEventsShort()
        {
            return db.FetchEvents().ToList().Select(x => x.ToUpcomingEventShortDTO()).ToList();
        }

        #endregion


        #region EventTypes

        public List<EventTypeDTO> FetchEventTypes()
        {
            return db.FetchEventTypes().ToList().Select(et => et.ToEventTypeDTO()).ToList();
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