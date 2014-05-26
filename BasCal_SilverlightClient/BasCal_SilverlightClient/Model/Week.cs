using BasCal_SilverlightClient.EventDataService;
using System;
using System.Collections.Generic;
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
using System.Linq;

namespace BasCal_SilverlightClient.Model
{
    public class Week
    {
        public ObservableCollection<Day> Days { get; set; }  

        public Week(ObservableCollection<Day> days)
        {
            this.Days = new ObservableCollection<Day>(days.OrderBy(x => x.Date));     
        }
    }
}
