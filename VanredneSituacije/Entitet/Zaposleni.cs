using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public abstract class Zaposleni
    {

        public Zaposleni()
        {
            Istorija = new List<IstorijaUloga>();
        }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string Email { get; set; }
        public virtual string AdresaStan { get; set; }

        public virtual string Pol { get; set; }

        public virtual IList<IstorijaUloga> Istorija { get; set; }

        public virtual DateTime DatumZap { get; set; }
        public virtual DateTime DatumRodj { get; set; }

    }
}
