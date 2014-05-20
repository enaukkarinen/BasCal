using BasCal_WCF_Host.DTO_Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BasCal_WCF_Host
{
    [ServiceContract]
    public interface IDBservice
    {
        #region Events

        [OperationContract]
        UpcomingEventDTO FetchEventByGuid(Guid guid);

        [OperationContract]
        List<UpcomingEventDTO> FetchUpcomingEvents();

        [OperationContract]
        List<UpcomingEventShortDTO> FetchUpcomingEventsShort();

        #endregion
        [OperationContract]
        int Add(int a, int b);
    }
}