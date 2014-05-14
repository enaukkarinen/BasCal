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

using Harkkaprojekti.ServiceReference1;

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

            App.Current.Host.Content.Resized +=Content_Resized;

            DB_ServiceClient client = new DB_ServiceClient();
            client.FetchUpcomingEventsShortCompleted += client_FetchUpcomingEventsShortCompleted;
            client.FetchUpcomingEventsShortAsync();
        }

        void client_FetchUpcomingEventsShortCompleted(object sender, FetchUpcomingEventsShortCompletedEventArgs e)
        {
            listboxUpcomingEvents.ItemsSource = e.Result;
        }


        void Content_Resized(object sender, EventArgs e)
        {
            this.Width = App.Current.Host.Content.ActualWidth;
            this.Height = App.Current.Host.Content.ActualHeight;
        }







    }
}
