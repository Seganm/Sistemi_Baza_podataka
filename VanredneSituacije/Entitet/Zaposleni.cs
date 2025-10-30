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
        public virtual string Kontakt_Telefon { get; set; }
        public virtual string Email { get; set; }
        public virtual string AdresaStanovanja { get; set; }

        public virtual string Pol { get; set; }

        public virtual IList<IstorijaUloga> Istorija { get; set; }

        public virtual DateTime Datum_Zaposlenja { get; set; }
        public virtual DateTime Datum_Rodjenja { get; set; }

    }
}
