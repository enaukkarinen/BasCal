using BasCal_SilverlightClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BasCal_SilverlightClient.View
{
    public partial class CalendarCell : UserControl
    {
        private Day day;

        public Day Day { get; set; }
        public CalendarCell()
        {
            InitializeComponent();
        }
    }
}
