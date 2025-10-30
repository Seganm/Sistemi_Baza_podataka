using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class EvidencijaServis
    {
        public virtual int Id { get; set; }
        public virtual string TipServisa { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual Vozilo Vozilo { get; set; }

    }
}
