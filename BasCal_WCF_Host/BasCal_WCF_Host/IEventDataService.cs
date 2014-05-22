using BasCal_WCF_Host.DTO_Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BasCal_WCF_Host
{
    [ServiceContract]
    public interface IEventDataService
    {
        #region Events

        [OperationContract]
        List<EventTypeDTO> FetchEventTypes();

        [OperationContract]
        string AddOrUpdateEvent(UpcomingEventDTO eve);

        [OperationContract]
        List<UpcomingEventShortDTO> FetchEventsByMonth(int m);

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