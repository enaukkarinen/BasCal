using BasCal_SilverlightClient.CommandBase;
using BasCal_SilverlightClient.EventDataService;
using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BasCal_SilverlightClient.Model
{
    public class Day : ViewModelBase
    {
        private DateTime date;
        private ObservableCollection<UpcomingEventShortDTO> daysEvents;

        public DateTime Date 
        {
            get { return date; }
            set 
            {
                date = value;
                OnPropertyChanged("Date");
            } 
        }
        public ObservableCollection<UpcomingEventShortDTO> DaysEvents 
        {
            get { return daysEvents; }
            set 
            {
                daysEvents = value;
                OnPropertyChanged("DaysEvents");
            }
        }

        public Day()
        {
            this.DaysEvents = new ObservableCollection<UpcomingEventShortDTO>();
        }
     
    }
}
