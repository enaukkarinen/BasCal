using BasCal_SilverlightClient.EventDataService;
using BasCal_SilverlightClient.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace BasCal_SilverlightClient.View
{
    public partial class CalendarCell : UserControl
    {
        public CalendarCell()
        {
            InitializeComponent();
        }
       
        private void CellGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            CellGrow.Begin();
        }

        private void CellGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            CellShrink.Begin();
        }
    }
}
