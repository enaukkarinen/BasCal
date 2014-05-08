﻿using WcfService.Model;
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
        public string HaeKayttajanNimi(int id)
        {
            try
            {
                Kalenteri_DBEntities entity = new Kalenteri_DBEntities();
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
