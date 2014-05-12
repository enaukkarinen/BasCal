using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFC_Palvelu.Models
{
    public partial class Tapahtumatyyppi
    {
        // Ominaisuudet
        public int TyyppiId { get; set; }
        public string Nimi { get; set; }

        // Navigaatio-ominaisuudet
        public virtual ICollection<Tapahtuma> Tapahtumat { get; set; }

        public Tapahtumatyyppi()
        {
            Tapahtumat = new List<Tapahtuma>();
        }
    }
}
