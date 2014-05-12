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

        void client_FetchThroughClassLibAndFromDBAsStringCompleted(object sender, FetchThroughClassLibAndFromDBAsStringCompletedEventArgs e)
        {
            List<string> lista = e.Result.ToList();

            testBlock.Text = "";
            foreach (string nimi in lista)
            {
                testBlock.Text += nimi + " \r\n ";
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Harkkaprojekti.WCF_Solution_Ref.DB_ServiceClient client = new DB_ServiceClient();
            client.FetchThroughClassLibAndFromDBAsStringCompleted += client_FetchThroughClassLibAndFromDBAsStringCompleted;
            client.FetchThroughClassLibAndFromDBAsStringAsync();
        }





    }
}
