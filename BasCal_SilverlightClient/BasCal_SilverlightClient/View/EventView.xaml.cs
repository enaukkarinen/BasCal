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
using BasCal_SilverlightClient.View;

namespace BasCal_SilverlightClient.View
{
    public partial class EventView : UserControl
    {

        public EventView()
        {
            InitializeComponent();
            HideEventFullInfoBox.Completed += HideEventFullInfoBox_Completed;
            HideDayInfo.Completed += HideDayInfo_Completed;
        }

        private void image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (LeftPanelGrid.Width == 25)
            {
                LeftPanelSlideIn.Begin();
            }
            else
            {
                LeftPanelSlideBack.Begin();
            }
        }

        private void UpcomingEventListItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
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

        private void AddEventGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            EventFullInfo.Visibility = System.Windows.Visibility.Visible;
            ShowEventFullInfoBox.Begin();
        }

        private void RightPanelCharmsBar_MouseEnter(object sender, MouseEventArgs e)
        {
            CharmsBarSlideIn.Begin();
        }

        private void RightPanelCharmsBar_MouseLeave(object sender, MouseEventArgs e)
        {
            CharmsBarSlideOut.Begin();
        }

        private void CalendarDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CalendarDataGrid.SelectedIndex = -1;
            DayInfoGrid.Visibility = System.Windows.Visibility.Visible;
            ShowDayInfo.Begin();
        }

        private void btnDayInfoClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            HideDayInfo.Begin();
        }

        void HideDayInfo_Completed(object sender, EventArgs e)
        {
            DayInfoGrid.Visibility = System.Windows.Visibility.Collapsed;
        }

    }
}
