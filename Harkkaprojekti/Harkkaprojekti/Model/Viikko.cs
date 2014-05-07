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
using System.ComponentModel;
using System.Diagnostics;

namespace Harkkaprojekti.Model
{
    public class Viikko
    {
        private Paiva _maanantai;
        private Paiva _tiistai; 
        private Paiva _keskiviikko; 
        private Paiva _torstai; 
        private Paiva _perjantai; 
        private Paiva _lauantai;
        private Paiva _sunnuntai;

        public Paiva Maanantai
        {
            get { return _maanantai; }
            set
            {
                _maanantai = value;
                Fire("Maanantai");
            }
        }
        public Paiva Tiistai
        {
            get { return _tiistai; }
            set 
            { 
                _tiistai = value;
                Fire("Tiistai");
            }
        }
        

        public Paiva Keskiviikko
        {
            get { return _keskiviikko; }
            set
            {
                _keskiviikko = value;
                Fire("Keskiviikko");
            }
        }
        

        public Paiva Torstai
        {
            get { return _torstai; }
            set
            {
                _torstai = value;
                Fire("Torstai");
            }
        }
        

        public Paiva Perjantai
        {
            get { return _perjantai; }
            set
            {
                _perjantai = value;
                Fire("Perjantai");
            }
        }
        

        public Paiva Lauantai
        {
            get { return _lauantai; }
            set
            {
                _lauantai = value;
                Fire("Lauantai");
            }
        }
        

        public Paiva Sunnuntai
        {
            get { return _sunnuntai; }
            set
            {
                _sunnuntai = value;
                Fire("Sunnuntai");
            }
        }

        public List<Paiva> Viikonpaivat { get; set; }
       


        public Viikko()
        {
            Viikonpaivat = new List<Paiva>();
            Viikonpaivat.Add(Maanantai);
            Viikonpaivat.Add(Tiistai);
            Viikonpaivat.Add(Keskiviikko);
            Viikonpaivat.Add(Torstai);
            Viikonpaivat.Add(Perjantai);
            Viikonpaivat.Add(Lauantai);
            Viikonpaivat.Add(Sunnuntai);
            Viikonpaivat.Add(Maanantai);
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
