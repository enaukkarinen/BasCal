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
using BasCal_SilverlightClient.EventDataService;
using System.Collections.ObjectModel;
using System.ComponentModel;
using BasCal_SilverlightClient.Model;
using System.Diagnostics;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using Microsoft.Expression.Interactivity.Core;
using BasCal_SilverlightClient.CommandBase;

namespace BasCal_SilverlightClient.ViewModel
{
    public class EventViewModel : ViewModelBase
    {
        private EventDataServiceClient client;
        private BasCal_SilverlightClient.Model.UpcomingEventWithValidation upcomingEventInFull;
        private ObservableCollection<UpcomingEventShortDTO> upcomingEventsInShortFormatList;
        private ObservableCollection<Week> weeks;


        public ObservableCollection<UpcomingEventShortDTO> UpcomingEventsInShortFormatList
        {
            get { return upcomingEventsInShortFormatList; }
            set
            {
                upcomingEventsInShortFormatList = value;
                OnPropertyChanged("UpcomingEventsInShortFormatList");
            }
        }

        public BasCal_SilverlightClient.Model.UpcomingEventWithValidation UpcomingEventInFull
        {
            get { return upcomingEventInFull; }
            set 
            {
                if (value != null)
                {
                    //var val = value.GetType().GetProperty("Name").GetValue(typeof(string), true);
                    upcomingEventInFull = value;
                    OnPropertyChanged("UpcomingEventInFull");
                }

            }
        }

        public ObservableCollection<Week> Weeks
        {
            get { return weeks; }
            set 
            {
                if (weeks != value)
                {
                    weeks = value;
                    OnPropertyChanged("Weeks");
                }
            }
        }


        private ICommand loadFullEventDataByGuid;
        public ICommand LoadFullEventDataByGuid
        {
            get { return loadFullEventDataByGuid; }
        }

        // Commands binded in xaml
        public ICommand LoadCalendar { get; set; }
        public ICommand LoadUpcomingEventList { get; set; }     
        public ICommand SaveEvent { get; set; }
        public ICommand AddEvent { get; set; }


        // Constructor
        public EventViewModel()
        {
            client = new EventDataServiceClient();
            client.FetchUpcomingEventsShortCompleted += client_FetchUpcomingEventsShortCompleted;
            client.FetchEventByGuidCompleted += client_FetchEventByGuidCompleted;
            client.FetchEventsByMonthCompleted += client_FetchEventsByMonthCompleted;
            client.AddOrUpdateEventCompleted += client_AddOrUpdateEventCompleted;


            this.LoadUpcomingEventList = new DelegateCommand(FetchUpcomingEventShortInShortFormat, CanExecute);
            this.LoadCalendar = new DelegateCommand(FetchEventsByMonth, CanExecute);
            this.SaveEvent = new DelegateCommand(AddOrUpdateEventInDatabase, CanExecute);
            this.AddEvent = new DelegateCommand(DestroyUpcomingEventInFull, CanExecute);
            this.loadFullEventDataByGuid = new DelegateCommand(FetchUpcomingEventByGuid, CanExecute);
        }

        public void FetchUpcomingEventByGuid(object parameter)
        {
            Guid guid = ((UpcomingEventShortDTO)parameter).EventId;
            client.FetchEventByGuidAsync(guid);
        }

        public void DestroyUpcomingEventInFull(object parameter)
        {
            this.UpcomingEventInFull = new BasCal_SilverlightClient.Model.UpcomingEventWithValidation() 
            { 
                Name = "New event",
                EventId = Guid.NewGuid(), 
                StartTime = DateTime.Now, 
                EndTime = DateTime.Now.AddHours(1),
                TypeId = 0,
                Type = "Unspecified"
            };
        }

        public void AddOrUpdateEventInDatabase(object parameter)
        {
            this.client.AddOrUpdateEventAsync(this.UpcomingEventInFull.ToWCFUpcomingEventDTO());
        }
        void client_AddOrUpdateEventCompleted(object sender, AddOrUpdateEventCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
            client.FetchEventsByMonthAsync(5);
        }
        public void FetchUpcomingEventShortInShortFormat(object parameter)
        {
            client.FetchUpcomingEventsShortAsync();
        }
        void client_FetchEventsByMonthCompleted(object sender, FetchEventsByMonthCompletedEventArgs e)
        {
            FillCalendarDataGrid(e.Result);
        }

        private void FetchEventsByMonth(object parameter)
        {
            client.FetchEventsByMonthAsync(5);
        }

        private void FillCalendarDataGrid(ObservableCollection<UpcomingEventShortDTO> returnedList)
        {
            ObservableCollection<Week> test = WeekFactory.WeekBuilder(returnedList);    
            this.Weeks = WeekFactory.WeekBuilder(returnedList);                       
        }


        void client_FetchUpcomingEventsShortCompleted(object sender, FetchUpcomingEventsShortCompletedEventArgs e)
        {
            UpcomingEventsInShortFormatList = new ObservableCollection<UpcomingEventShortDTO>(e.Result.OrderByDescending(ev => ev.StartTime));
        }
        void client_FetchEventByGuidCompleted(object sender, FetchEventByGuidCompletedEventArgs e)
        {
            UpcomingEventInFull = new Model.UpcomingEventWithValidation(e.Result);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

    }
}
