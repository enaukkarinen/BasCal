using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class KayttajanKalenteri
    {
        [DataMember]
        public Kayttaja Kayttaja { get; set; }
        
        [DataMember]
        public List<Tapahtuma> Tapahtumat { get; set; }

        [DataMember]
        public List<Ryhma> Ryhmat { get; set; }

    }
}