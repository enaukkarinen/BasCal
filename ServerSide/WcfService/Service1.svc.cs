using WcfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Linq;
using System.Data.Entity;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private Kalenteri_DBEntities entity = new Kalenteri_DBEntities();

        public List<string> HaeKayttajanTapahtumienNimet(int id)
        {
            return entity.KayttajanTapahtumat.Where(k => k.KayttajaId == id).Select(k => k.Tapahtuma.Nimi).ToList();
        }

        public List<Ryhma> HaeKayttajanRyhmat(int id)
        {
            return entity.RyhmanJasenet.Where(k => k.KayttajaId == id).Select(k => k.Ryhma).ToList();
        }


        public KayttajanKalenteri HaeKayttajanKalenteri(int id)
        {
            KayttajanKalenteri kalenteri = new KayttajanKalenteri();
            kalenteri.Kayttaja = entity.Kayttaja.Where(k => k.KayttajaId == id).FirstOrDefault();
            kalenteri.Tapahtumat = entity.KayttajanTapahtumat.Where(k => k.KayttajaId == id).Select(k => k.Tapahtuma).ToList();
            kalenteri.Ryhmat = entity.RyhmanJasenet.Where(k => k.KayttajaId == id).Select(k => k.Ryhma).ToList();

            return kalenteri;

        }


        public string HaeKayttajanNimi(int id)
        {
            try
            {           
                var nimi = entity.Kayttaja.Where(k => k.KayttajaId == id).SingleOrDefault().Etunimi;
                return nimi;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<string> haeKaikkienKayttajienNimet()
        {
            return new List<string>() { "eka", "toka" };
        }
    }
}
