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

using Harkkaprojekti.KalenteriServiceReference;

namespace Harkkaprojekti.View
{
    public partial class KuukausiView : Page
    {
        KalenteriServiceReference.KalenteriServiceClient asiakas;

        public KuukausiView()
        {
            InitializeComponent();
            foreach (var c in kalenteriGrid.Columns)
            {
                c.CanUserSort = false;
            }


            asiakas = new KalenteriServiceReference.KalenteriServiceClient();
            asiakas.AddCompleted += asiakas_AddCompleted;

        }

        void asiakas_AddCompleted(object sender, AddCompletedEventArgs e)
        {
            if (e.Result != -1)
                MessageBox.Show(e.Result.ToString());
        }



        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            asiakas.AddAsync(44, 25);
        }



    }
}
