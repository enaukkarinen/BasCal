using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFC_Palvelu.Models
{
    
    public partial class Tapahtuma
    {
        public int TapahtumaId { get; set; }
        public int TyyppiId { get; set; }
        public DateTime AlkamisAika { get; set; }
        public DateTime PaattymisAika { get; set; }
        public string Paikka { get; set; }
        public string Nimi { get; set; }
        public string Kuvaus { get; set; }

        // Navigaatio-ominaisuudet
        public virtual Tapahtumatyyppi TapahtumaTyyppi { get; set; }
        public virtual ICollection<KayttajanTapahtumat>  KayttajanTapahtumat { get; set; }

        public Tapahtuma()
        {
            this.KayttajanTapahtumat = new List<KayttajanTapahtumat>();
        }
    }
}
