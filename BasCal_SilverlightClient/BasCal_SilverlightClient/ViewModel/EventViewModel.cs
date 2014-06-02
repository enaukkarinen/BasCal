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
using System.Reactive.Concurrency;

using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Threading;
using System.Reactive.Joins;
using System.Threading;

namespace BasCal_SilverlightClient.ViewModel
{
    public class EventViewModel : ViewModelBase
    {
        private DateTime desiredMonth;       
        private UpcomingEventWithValidation upcomingEventInFull;
        private ObservableCollection<UpcomingEventShortDTO> upcomingEventsInShortFormatList;
        private ObservableCollection<Week> weeks;
        private Day day;

        #region Properties

        public DateTime DesiredMonth
        {
            get 
            {
                if(desiredMonth == new DateTime())
                    return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                else
                return desiredMonth; 
            }
            set
            {
                if (value != null && value != new DateTime())
                {
                    desiredMonth = value;
                    OnPropertyChanged("DesiredMonth");
                }
            }
        }
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
        public Day Day
        {
            get { return day; }
            set 
            {
                if (value != null)
                {
                    day = value;
                    OnPropertyChanged("Day");
                }
            }
        }
        
        #endregion

        #region Commands

        public ICommand SwitchMonth 
        {
            get { return new DelegateCommand(FetchEventsByMonth); }
        }
        public ICommand DataGridDaySelection  
        {
            get
            {
                return new DelegateCommand((object obj) =>
                {
                    Day value = (Day)obj;
                    if (value != null)
                    {
                        this.Day = (Day)obj;
                    }
                });
            }
        }
        public ICommand LoadMonth
        {
            get { return new DelegateCommand(FetchEventsByMonth); }
        }      
        public ICommand LoadUpcomingEventList 
        {
            get { return new DelegateCommand(FetchUpcomingEventsInShortFormat); }
        }            
        public ICommand SaveEvent 
        {
            get { return new DelegateCommand(AddOrUpdateEventInDatabase); }
        }
        public ICommand AddEvent 
        {
            get { return new DelegateCommand(DestroyUpcomingEventInFull); }
        }      
        public ICommand LoadFullEventDataFromList 
        {
            get { return new DelegateCommand(FetchFullEventInfoFromList); }
        }

        #endregion

        public EventViewModel()
        {
        }

        /// <summary>
        /// Retrieves a collection of events in a shortened format.
        /// </summary>
        /// <param name="parameter"></param>
        public void FetchUpcomingEventsInShortFormat(object parameter)
        {
            IObservable<ObservableCollection<UpcomingEventShortDTO>> events =
               EventServiceProxy.FetchUpcomingEventsInShortFormat().ObserveOn(SynchronizationContext.Current);
            events.Subscribe(eve => this.UpcomingEventsInShortFormatList = 
                new ObservableCollection<UpcomingEventShortDTO>(eve.OrderByDescending(ev => ev.StartTime)));
        }

        /// <summary>
        /// Retrieves events by month and creates a week collection.
        /// </summary>
        /// <param name="parameter"></param>
        private void FetchEventsByMonth(object parameter)
        {        
            if (parameter == null)
                this.DesiredMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            else
            {
                int monthIncrement = ((MouseWheelEventArgs)parameter).Delta;
                if (monthIncrement > 0)
                    this.DesiredMonth = this.DesiredMonth.AddMonths(-1);
                else
                    this.DesiredMonth = this.DesiredMonth.AddMonths(1);
            }

            IObservable<ObservableCollection<UpcomingEventShortDTO>> events = 
                EventServiceProxy.FetchEventsByMonth(this.DesiredMonth.Month).ObserveOn(SynchronizationContext.Current);
            events.Subscribe(eve => this.Weeks = WeekFactory.WeekBuilder(this.DesiredMonth, eve));
        }

        /// <summary>
        /// Retrieves full event info
        /// </summary>
        /// <param name="parameter"></param>
        public void FetchFullEventInfoFromList(object parameter)
        {
            if (parameter != null)
            {
                IObservable<UpcomingEventDTO> eventInFull = EventServiceProxy.FetchEventByGuid(((UpcomingEventShortDTO)parameter).EventId)
                    .ObserveOn(SynchronizationContext.Current);
                eventInFull.Subscribe(rx => this.UpcomingEventInFull = new UpcomingEventWithValidation(rx));
            }
        }

        /// <summary>
        /// Send an event instance to server and updates the corresponding row in database
        /// </summary>
        /// <param name="parameter"></param>
        public void AddOrUpdateEventInDatabase(object parameter)
        {
            IObservable<string> reply = EventServiceProxy.AddOrUpdateEvent(this.UpcomingEventInFull.ToWCFUpcomingEventDTO())
                    .ObserveOn(SynchronizationContext.Current);
            reply.Subscribe(rx => MessageBox.Show(rx));

            IObservable<ObservableCollection<UpcomingEventShortDTO>> events = EventServiceProxy.FetchEventsByMonth(
                this.DesiredMonth.Month).ObserveOn(SynchronizationContext.Current);
            events.Subscribe(eve => this.Weeks = WeekFactory.WeekBuilder(this.DesiredMonth, eve));
        }

        /// <summary>
        /// Formats the eventform
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
