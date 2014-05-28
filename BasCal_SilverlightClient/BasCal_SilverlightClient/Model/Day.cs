using BasCal_SilverlightClient.EventDataService;
using System;
using System.Collections.ObjectModel;

namespace BasCal_SilverlightClient.Model
{
    public class Day
    {
        public DateTime Date { get; set; }
        public ObservableCollection<UpcomingEventShortDTO> DaysEvents { get; set; }

        public Day()
        {
            this.DaysEvents = new ObservableCollection<UpcomingEventShortDTO>();
        }     
    }
}
