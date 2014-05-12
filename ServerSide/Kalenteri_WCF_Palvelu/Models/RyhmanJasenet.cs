using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFC_Palvelu.Models
{
    public partial class RyhmanJasenet
    {
        public int KayttajaId { get; set; }
        public int RyhmaId { get; set; }
        public string Rooli { get; set; }

        // Navigaatio-ominaisuudet
        public virtual Kayttaja Kayttaja { get; set; }
        public virtual Ryhma Ryhma { get; set; }
    }
}
