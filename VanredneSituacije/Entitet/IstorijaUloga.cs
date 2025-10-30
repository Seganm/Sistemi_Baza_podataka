using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class IstorijaUloga
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum_Od { get; set; }
        public virtual DateTime? Datum_Do { get; set; }
        public virtual string Uloga { get; set; }
        public virtual Zaposleni Zaposleni { get; set; }
    }
}
