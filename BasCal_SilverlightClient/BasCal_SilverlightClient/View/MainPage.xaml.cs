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
using BasCal_SilverlightClient.ViewModel;

namespace BasCal_SilverlightClient
{
    public partial class MainPage : UserControl
    {

        public MainPage()
        {
            InitializeComponent();
 

            HideEventFullInfoBox.Completed += HideEventFullInfoBox_Completed;
        }


        private void image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (RightPanelGrid.Width == 25)
                {
                    ((EventViewModel)this.DataContext).FetchUpcomingEventShortInShortFormat();
                    RightPanelSlideIn.Begin();
                }
                else
                {
                    RightPanelSlideBack.Begin();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Is WFC running? \r\n \r\n" + exc.Message);
            }
          

        }

        private void UpcomingEventListItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string eventId = ((TextBlock)((Grid)((StackPanel)sender).Children[0]).Children[0]).Text;
            ((EventViewModel)this.DataContext).FetchUpcomingEventByGuid(new Guid(eventId));
            EventFullInfo.Visibility = System.Windows.Visibility.Visible;
            ShowEventFullInfoBox.Begin();

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
