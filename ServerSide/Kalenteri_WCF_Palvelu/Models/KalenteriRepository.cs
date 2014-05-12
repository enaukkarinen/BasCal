using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WFC_Palvelu.Models
{
    public class KalenteriRepository
    {
        private KalenteriContext kc = new KalenteriContext();

        // Käyttäjä
        public IQueryable<Kayttaja> HaeKaikkiKayttajat()
        {
            return kc.Kayttajat;
        }
        
        public void LisaaKayttaja(Kayttaja k)
        {
            kc.Kayttajat.Add(k);
            kc.SaveChanges();
        }

        public Kayttaja HaeKayttaja(int id)
        {
            return kc.Kayttajat.Where(k => k.KayttajaId == id).FirstOrDefault();
        }
    }
}