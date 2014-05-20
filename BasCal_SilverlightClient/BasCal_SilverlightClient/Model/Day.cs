﻿using BasCal_SilverlightClient.ServiceReference1;
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
    public class Day
    {
        public string testi { get; set; }
        public ObservableCollection<UpcomingEventShortDTO> DaysEvents { get; set; }
        public DateTime Date { get; set; }
        public int WeekNumber { get; set; }

        public Day()
        {
            this.DaysEvents = new ObservableCollection<UpcomingEventShortDTO>();
            testi = "hello";
        }
    }
}