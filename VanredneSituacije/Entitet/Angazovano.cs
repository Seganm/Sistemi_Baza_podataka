using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Angazovano
    {
        public virtual int ID { get; set; }
        public virtual DateTime? Datum_Do { get; set; }
        public virtual DateTime Datum_Od { get; set; }

        public virtual Intervencija Intervencija { get; set; }

        public virtual Vozilo Vozilo { get; set; }


    }
}
