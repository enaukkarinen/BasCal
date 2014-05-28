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
using BasCal_SilverlightClient.Services;

namespace BasCal_SilverlightClient.ViewModel
{
    public class EventViewModel : ViewModelBase
    {
        private UpcomingEventWithValidation upcomingEventInFull;
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
        public UpcomingEventWithValidation UpcomingEventInFull
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

        // Commands binded in xaml
        #region Commands

        public ICommand LoadMonth
        {
            get { return new DelegateCommand(FetchEventsByMonth, (x) => { return true; } ); }
        }      
        public ICommand LoadUpcomingEventList 
        {
            get { return new DelegateCommand(FetchUpcomingEventsInShortFormat, (x) => { return true; }); }
        }            
        public ICommand SaveEvent 
        {
            get { return new DelegateCommand(AddOrUpdateEventInDatabase, (x) => { return true; } ); }
        }
        public ICommand AddEvent 
        {
            get { return new DelegateCommand(DestroyUpcomingEventInFull, (x) => { return true; }); }
        }      
        public ICommand LoadFullEventDataFromList 
        {
            get { return new DelegateCommand(FetchFullEventInfoFromList, (x) => { return true; }); }
        }

        #endregion

        // Constructor
        public EventViewModel()
        {
        }


        private void DaySelection(object obj)
        {
            Day asd = (Day)obj;
            MessageBox.Show("selection");
        }



        /// <summary>
        /// Retrieves a collection of events in a shortened format.
        /// </summary>
        /// <param name="parameter"></param>
        public async void FetchUpcomingEventsInShortFormat(object parameter)
        {
            var results = await EventServiceProxy.FetchUpcomingEventsInShortFormat();
            UpcomingEventsInShortFormatList = new ObservableCollection<UpcomingEventShortDTO>(results.OrderByDescending(ev => ev.StartTime));
        }

        /// <summary>
        /// Retrieves events by month and creates a week collection.
        /// </summary>
        /// <param name="parameter"></param>
        private async void FetchEventsByMonth(object parameter)
        {
            var results = await EventServiceProxy.FetchEventsByMonth(5);
            this.Weeks = WeekFactory.WeekBuilder(results);    
        }

        /// <summary>
        /// Retrieves full event info
        /// </summary>
        /// <param name="parameter"></param>
        public async void FetchFullEventInfoFromList(object parameter)
        {
            if (parameter != null)
            {
                var result = await EventServiceProxy.FetchEventByGuid(((UpcomingEventShortDTO)parameter).EventId);
                UpcomingEventInFull = new UpcomingEventWithValidation(result);
            }
        }

        /// <summary>
        /// Send an event instance to server and updates the corresponding row in database
        /// </summary>
        /// <param name="parameter"></param>
        public async void AddOrUpdateEventInDatabase(object parameter)
        {
            var result = await EventServiceProxy.AddOrUpdateEvent(this.UpcomingEventInFull.ToWCFUpcomingEventDTO());
            MessageBox.Show(result);
            FetchEventsByMonth(new Object());
        }

        /// <summary>
        /// Formats an Event
        /// </summary>
        /// <param name="parameter"></param>
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



    }
}
