﻿using System;
using System.Collections.Generic;
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
    public class Paiva
    {
        private List<Tapahtuma> _paivanTapahtumat;

        public List<Tapahtuma> PaivanTapahtumat
        {
            get { return _paivanTapahtumat; }
            set 
            { 
                _paivanTapahtumat = value;
                Fire("Paivantapahtumat");
            }
        }

        public Paiva()
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