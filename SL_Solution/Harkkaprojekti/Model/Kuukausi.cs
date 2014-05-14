using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace Harkkaprojekti.Model
{
    public class Kuukausi : INotifyPropertyChanged
    {
        private ObservableCollection<Viikko> _viikot;

        public ObservableCollection<Viikko> Viikot
        {
            get { return _viikot; } 
            set
            {
                _viikot = value;
                Fire("Viikot");
            }
        }

        public Kuukausi()
        {

        }

        public void Fire(string str)
        {
            if (PropertyChanged != null)
            {
                Debug.WriteLine(str);
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
