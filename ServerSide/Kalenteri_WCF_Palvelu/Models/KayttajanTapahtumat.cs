using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFC_Palvelu.Models
{
    public partial class KayttajanTapahtumat
    {
        // Ominaisuudet
        public int TapahtumaId { get; set; }
        public int KayttajaId { get; set; }

        // Navigaatio-ominaisuudet
        public virtual Tapahtuma Tapahtuma { get; set; }
        public virtual Kayttaja Kayttaja { get; set; }
    }
}
