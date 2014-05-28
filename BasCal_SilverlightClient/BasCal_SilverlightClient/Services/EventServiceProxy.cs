using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BasCal_SilverlightClient.EventDataService;
using System;

namespace BasCal_SilverlightClient.Services
{
    public class EventServiceProxy
    {
        public static Task<string> AddOrUpdateEvent(UpcomingEventDTO guid)
        {
            var tcs = new TaskCompletionSource<string>();

            var client = new EventDataService.EventDataServiceClient();

            client.AddOrUpdateEventCompleted += (s, e) =>
            {
                if (e.Error != null)
                    tcs.TrySetException(e.Error);
                else if (e.Cancelled)
                    tcs.TrySetCanceled();
                else
                    tcs.TrySetResult(e.Result);
            };

            client.AddOrUpdateEventAsync(guid);

            return tcs.Task;
        }

        public static Task<UpcomingEventDTO> FetchEventByGuid(Guid guid)
        {
            var tcs = new TaskCompletionSource<UpcomingEventDTO>();

            var client = new EventDataService.EventDataServiceClient();

            client.FetchEventByGuidCompleted += (s, e) =>
            {
                if (e.Error != null)
                    tcs.TrySetException(e.Error);
                else if (e.Cancelled)
                    tcs.TrySetCanceled();
                else
                    tcs.TrySetResult(e.Result);
            };

            client.FetchEventByGuidAsync(guid);

            return tcs.Task;
        }

        public static Task<ObservableCollection<UpcomingEventShortDTO>> FetchEventsByMonth(int month)
        {
            var tcs = new TaskCompletionSource<ObservableCollection<UpcomingEventShortDTO>>();

            var client = new EventDataService.EventDataServiceClient();

            client.FetchEventsByMonthCompleted += (s, e) =>
            {
                if (e.Error != null)
                    tcs.TrySetException(e.Error);
                else if (e.Cancelled)
                    tcs.TrySetCanceled();
                else
                    tcs.TrySetResult(e.Result);
            };

            client.FetchEventsByMonthAsync(month);

            return tcs.Task;
        }

        public static Task<ObservableCollection<UpcomingEventShortDTO>> FetchUpcomingEventsInShortFormat()
        {
            var tcs = new TaskCompletionSource<ObservableCollection<UpcomingEventShortDTO>>();

            var client = new EventDataService.EventDataServiceClient();

            client.FetchUpcomingEventsShortCompleted += (s, e) =>
            {
                if (e.Error != null)
                    tcs.TrySetException(e.Error);
                else if (e.Cancelled)
                    tcs.TrySetCanceled();
                else
                    tcs.TrySetResult(e.Result);
            };

            client.FetchUpcomingEventsShortAsync();

            return tcs.Task;
        }
    }
}