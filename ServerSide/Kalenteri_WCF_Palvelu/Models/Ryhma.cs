using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFC_Palvelu.Models
{
    public partial class Ryhma
    {
        public int RyhmaId { get; set; }
        public string Nimi { get; set; }

        // Navigaatio-ominaisuudet
        public virtual ICollection<RyhmanJasenet> RyhmanJasenet { get; set; }

        public Ryhma()
        {
            RyhmanJasenet = new List<RyhmanJasenet>();
        }
    }
}
