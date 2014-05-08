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
        ServiceReference1.Service1Client asiakas;

        public KuukausiView()
        {
            InitializeComponent();
            foreach (var c in kalenteriGrid.Columns)
            {
                c.CanUserSort = false;
            }


            asiakas = new ServiceReference1.Service1Client();
            asiakas.HaeKayttajanNimiCompleted += asiakas_HaeKayttajanNimiCompleted;
            asiakas.haeKaikkienKayttajienNimetCompleted += asiakas_haeKaikkienKayttajienNimetCompleted;
        }

        void asiakas_haeKaikkienKayttajienNimetCompleted(object sender, haeKaikkienKayttajienNimetCompletedEventArgs e)
        {
            foreach (var nimi in e.Result)
            {
                MessageBox.Show(nimi);
            }
        }

        void asiakas_HaeKayttajanNimiCompleted(object sender, HaeKayttajanNimiCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            asiakas.HaeKayttajanNimiAsync(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            asiakas.haeKaikkienKayttajienNimetAsync();
        }




    }
}
