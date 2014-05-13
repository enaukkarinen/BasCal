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
using System.Windows.Navigation;

using Harkkaprojekti.WCF_Solution_Ref;

namespace Harkkaprojekti.View
{
    public partial class KuukausiView : Page
    {

        public KuukausiView()
        {
            InitializeComponent();
            foreach (var c in kalenteriGrid.Columns)
            {
                c.CanUserSort = false;
            }

            
        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Harkkaprojekti.WCF_Solution_Ref.DB_ServiceClient client = new DB_ServiceClient();
            client.FetchUpcomingEventsCompleted += client_FetchUpcomingEventsCompleted;
            client.FetchUpcomingEventsAsync();
        }

        void client_FetchUpcomingEventsCompleted(object sender, FetchUpcomingEventsCompletedEventArgs e)
        {

            listboxUpcomingEvents.ItemsSource = e.Result;
        }





    }
}
