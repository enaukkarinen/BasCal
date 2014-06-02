using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BasCal_SilverlightClient.EventDataService;
using System;
using System.Reactive.Linq;

namespace BasCal_SilverlightClient.Services
{
    public class EventServiceProxy
    {
        static IEventDataService client = (IEventDataService)new EventDataService.EventDataServiceClient();

        public static IObservable<UpcomingEventDTO> FetchEventByGuid(Guid guid)
        {
            //Func<Guid, IObservable<UpcomingEventDTO>> observableSearchFunc
            var observableSearchFunc = Observable.FromAsyncPattern<Guid, UpcomingEventDTO>
                (client.BeginFetchEventByGuid, client.EndFetchEventByGuid);
            return observableSearchFunc(guid);
        }

        public static IObservable<ObservableCollection<UpcomingEventShortDTO>> FetchEventsByMonth(int month)
        {
            var observableSearchFunc = Observable.FromAsyncPattern<int, ObservableCollection<UpcomingEventShortDTO>>
                (client.BeginFetchEventsByMonth, client.EndFetchEventsByMonth);            
            return observableSearchFunc(month);
        }
        public static IObservable<string> AddOrUpdateEvent(UpcomingEventDTO eve)
        {
            var observableSearchFunc = Observable.FromAsyncPattern<UpcomingEventDTO, string>
                (client.BeginAddOrUpdateEvent, client.EndAddOrUpdateEvent);
            return observableSearchFunc(eve);
        }

        public static IObservable<ObservableCollection<UpcomingEventShortDTO>> FetchUpcomingEventsInShortFormat()
        {
            var observableSearchFunc = Observable.FromAsyncPattern<ObservableCollection<UpcomingEventShortDTO>>
                (client.BeginFetchUpcomingEventsShort, client.EndFetchUpcomingEventsShort);
            return observableSearchFunc();
        }
    }
}