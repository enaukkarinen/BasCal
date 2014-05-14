using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Harkkaprojekti.Model;
using System.Collections.ObjectModel;



namespace Harkkaprojekti.ViewModel
{
    public class KuukausiViewModel
    {
        

        public KuukausiViewModel()
        {
            Kuukausi kk = new Kuukausi();
            kk.Viikot = LuoViikot();
            Kuukausi = kk;
        }

        public Kuukausi Kuukausi { get; set; }

        public IList<Viikko> Viikot
        {
            get { return Kuukausi.Viikot; }
        }

        private void asd()
        {
            foreach (var viikko in Kuukausi.Viikot)
            {
                foreach (var paiva in viikko.Viikonpaivat)
                {
                    foreach (var x in paiva.PaivanTapahtumat)
                    {
                    }
                }
            }
        }
        private ObservableCollection<Viikko> LuoViikot()
        {
            ObservableCollection<Viikko> viikot = new ObservableCollection<Viikko>();

            Viikko vk1 = new Viikko()
            {
                Perjantai = new Paiva()
                {
                    PaivanTapahtumat = new List<Tapahtuma> 
                    { new Tapahtuma()
                        { Nimi = "Aloituskokous"}
                    }
                }
            };
            Viikko vk2 = new Viikko()
            {
                Keskiviikko = new Paiva()
                {
                    PaivanTapahtumat = new List<Tapahtuma> 
                    { new Tapahtuma()
                        { Nimi = "Ruokailu"}
                    }
                },
                Torstai = new Paiva()
                {
                    PaivanTapahtumat = new List<Tapahtuma> 
                    { new Tapahtuma()
                        { Nimi = "Joulu"}
                    }
                },
                Perjantai = new Paiva()
                {
                    PaivanTapahtumat = new List<Tapahtuma> 
                    { new Tapahtuma()
                        { Nimi = "Synttärit"}
                    }
                }
            };
            Viikko vk3 = new Viikko()
            {

            };
            Viikko vk4 = new Viikko()
            {
                Maanantai = new Paiva()
                {
                    PaivanTapahtumat = new List<Tapahtuma> { new Tapahtuma() { Nimi = "Ruokailu" }, new Tapahtuma() { Nimi = "Christmas" }, new Tapahtuma() { Nimi = "Easter" } }
                },
                Sunnuntai = new Paiva()
                {
                    PaivanTapahtumat = new List<Tapahtuma> 
                    { new Tapahtuma()
                        { Nimi = "Joulu"}
                    }
                },
            };

            viikot.Add(vk1);
            viikot.Add(vk2);
            viikot.Add(vk3);
            viikot.Add(vk4);
            return viikot;
        }
    }

}
