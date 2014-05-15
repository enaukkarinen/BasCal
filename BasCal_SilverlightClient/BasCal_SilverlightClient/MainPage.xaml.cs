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
using BasCal_SilverlightClient.ServiceReference1;

namespace BasCal_SilverlightClient
{
    public partial class MainPage : UserControl
    {
        ServiceReference1.DBserviceClient client;

        public MainPage()
        {
            InitializeComponent();

            client = new DBserviceClient();
            client.FetchUpcomingEventsShortCompleted += client_FetchUpcomingEventsShortCompleted;
            client.FetchEventByGuidCompleted += client_FetchEventByGuidCompleted;
            HideEventFullInfoBox.Completed += HideEventFullInfoBox_Completed;
        }


        void client_FetchUpcomingEventsShortCompleted(object sender, FetchUpcomingEventsShortCompletedEventArgs e)
        {
            listboxUpcomingEvents.ItemsSource = e.Result;
        }

        private void image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (RightPanelGrid.Width == 25)
            {
                client.FetchUpcomingEventsShortAsync();
                RightPanelSlideIn.Begin();
            }
            else
            {
                RightPanelSlideBack.Begin();
            }

        }

        private void UpcomingEventListItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string eventId = ((TextBlock)((Grid)((StackPanel)sender).Children[0]).Children[0]).Text;
            client.FetchEventByGuidAsync(new Guid(eventId));
            EventFullInfo.Visibility = System.Windows.Visibility.Visible;
            ShowEventFullInfoBox.Begin();

        }


        void client_FetchEventByGuidCompleted(object sender, FetchEventByGuidCompletedEventArgs e)
        {
            EventFullInfoInnerBox.DataContext = e.Result;
        }

        private void EventFullInfoCloseBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            HideEventFullInfoBox.Begin();
        }


        void HideEventFullInfoBox_Completed(object sender, EventArgs e)
        {
            EventFullInfo.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
