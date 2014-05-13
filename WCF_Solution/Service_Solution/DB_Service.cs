using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.ServiceModel.Web;
using DB_Solution;
using Service_Solution.DTO_Models;

namespace Service_Solution
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DB_Service : IDB_Service, IClientAccessPolicy
    {
        dbRepository db = new dbRepository();

        #region Events

        public List<EventDTO> FetchEvents()
        {
            return db.FetchEvents().Select(ev => new EventDTO { EventId = ev.EventId}).ToList();
        }

        public List<UpcomingEventDTO> FetchUpcomingEvents()
        {
            return db.FetchEvents().Select(ev => new UpcomingEventDTO 
            { 
                Name = ev.Name,
                Location = ev.Location,
                Summary = ev.Summary,
                StartTime = ev.StartTime,
                EndTime = ev.EndTime
            }).OrderByDescending(c=> c.StartTime).ToList();
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
