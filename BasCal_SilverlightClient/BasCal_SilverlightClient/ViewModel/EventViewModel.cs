using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using BasCal_SilverlightClient.ServiceReference1;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BasCal_SilverlightClient.ViewModel
{
    public class EventViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        private DBserviceClient client;
        private UpcomingEventDTO upcomingEventInFull;
        private ObservableCollection<UpcomingEventShortDTO> upcomingEventsInShortFormatList;

        public ObservableCollection<UpcomingEventShortDTO> UpcomingEventsInShortFormatList
        {
            get { return upcomingEventsInShortFormatList; }
            set
            {
                upcomingEventsInShortFormatList = value;
                RaisePropertyChanged("UpcomingEventsInShortFormatList");

            }
        }

        public UpcomingEventDTO UpcomingEventInFull
        {
            get { return upcomingEventInFull; }
            set 
            {
                upcomingEventInFull = value;
                RaisePropertyChanged("UpcomingEventInFull");
            }
        }
        public EventViewModel()
        {
            client = new DBserviceClient();
            client.FetchUpcomingEventsShortCompleted += client_FetchUpcomingEventsShortCompleted;
            client.FetchEventByGuidCompleted += client_FetchEventByGuidCompleted;
        }




        public void FetchUpcomingEventShortInShortFormat()
        {
            client.FetchUpcomingEventsShortAsync();
        }
        void client_FetchUpcomingEventsShortCompleted(object sender, FetchUpcomingEventsShortCompletedEventArgs e)
        {
            UpcomingEventsInShortFormatList = e.Result;
        }

        public void FetchUpcomingEventByGuid(Guid guid)
        {
            client.FetchEventByGuidAsync(guid);
        }
        void client_FetchEventByGuidCompleted(object sender, FetchEventByGuidCompletedEventArgs e)
        {
            UpcomingEventInFull = e.Result;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) 
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) 
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
