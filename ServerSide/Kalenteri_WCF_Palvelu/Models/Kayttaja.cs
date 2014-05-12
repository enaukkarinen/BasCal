using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFC_Palvelu.Models
{
    public partial class Kayttaja
    {
        public int KayttajaId { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }

        // Navigaatio-ominaisuudet
        public virtual ICollection<KayttajanTapahtumat> KayttajanTapahtumat { get; set; }
        public virtual ICollection<RyhmanJasenet> RyhmanJasenet { get; set; }

        public Kayttaja()
        {
            KayttajanTapahtumat = new List<KayttajanTapahtumat>();
            RyhmanJasenet = new List<RyhmanJasenet>();
        }
    }
}
