using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Harkkaprojekti.Model
{
    public class Tapahtuma : INotifyPropertyChanged
    {
        private string _nimi;

        // Bindaukset vaativat Propertyn. Kenttä ei kelpaa!
        public string Nimi
        {
            get { return _nimi; }
            set 
            {
                _nimi = value;
                Fire("Nimi");
            }
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
