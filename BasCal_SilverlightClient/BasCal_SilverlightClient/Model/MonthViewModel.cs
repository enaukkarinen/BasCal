using BasCal_SilverlightClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public class MonthViewModel : INotifyPropertyChanged
    {
        private int monthNumber;
        private int year;
        private string monthName;
        private ObservableCollection<Day> days;
        private ObservableCollection<Week> weeks;

        public ObservableCollection<Week> Weeks
        {
            get { return weeks; }
            set 
            { 
                weeks = value;
                RaisePropertyChanged("Weeks");
            }
        }

        public int MonthNumber
        {
            get { return monthNumber; }
            set 
            { 
                monthNumber = value;
                RaisePropertyChanged("MonthNumber");
            }
        }
        public int Year
        {
            get { return year; }
            set 
            { 
                year = value;
                RaisePropertyChanged("Year");
            }
        }
        public string MonthName
        {
            get { return monthName; }
            set 
            { 
                monthName = value; 
                RaisePropertyChanged("MonthName"); 
            }
        }
        public ObservableCollection<Day> Days
        {
            get { return days; }
            set 
            { 
                days = value;
                RaisePropertyChanged("Days");
            }
        }



        public MonthViewModel()
        {
            weeks = new ObservableCollection<Week>();
            weeks.Add(new Week());
            weeks.Add(new Week());
            weeks.Add(new Week());
            weeks.Add(new Week());
            weeks.Add(new Week());
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
