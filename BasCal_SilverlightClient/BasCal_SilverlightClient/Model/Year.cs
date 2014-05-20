using BasCal_SilverlightClient.ServiceReference1;
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

namespace BasCal_SilverlightClient.Model
{
    public class Year
    {
        public List<MonthViewModel> Months { get; set; }

        public Year()
        {
            Months = new List<MonthViewModel>()
            {
                new MonthViewModel(){MonthName = "January", MonthNumber = 1},
                new MonthViewModel(){MonthName = "February", MonthNumber = 2},
                new MonthViewModel(){MonthName = "March", MonthNumber = 3},
                new MonthViewModel(){MonthName = "April", MonthNumber = 4},
                new MonthViewModel(){MonthName = "May", MonthNumber = 5},
                new MonthViewModel(){MonthName = "June", MonthNumber = 6},
                new MonthViewModel(){MonthName = "July", MonthNumber = 7},
                new MonthViewModel(){MonthName = "August", MonthNumber = 8},
                new MonthViewModel(){MonthName = "September", MonthNumber = 9},
                new MonthViewModel(){MonthName = "October", MonthNumber = 10},
                new MonthViewModel(){MonthName = "November", MonthNumber = 12},
                new MonthViewModel(){MonthName = "December", MonthNumber = 12},
            };
        }

        //private bool IsLeapYear()
        //{
 
        //}
    }
}
