using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOIstorijaUloga
    {
        public DTOIstorijaUloga() { 
        }
        public DTOIstorijaUloga(IstorijaUloga iu)
        {
            JMBGZaposlenog = iu.Zaposleni.JMBG;
            Id = iu.Id;
            Datum_Od = iu.Datum_Od;
            Datum_Do = iu.Datum_Do;
            Uloga = iu.Uloga;
        }
        public virtual string JMBGZaposlenog { get; set; }
        public virtual int Id { get; set; }
        public virtual DateTime Datum_Od { get; set; }
        public virtual DateTime? Datum_Do { get; set; }

        public virtual string Uloga { get; set; }



    }
    public class DTODodajIstorijuUloga
    {
        public DTODodajIstorijuUloga() { 
        }
        public DTODodajIstorijuUloga(IstorijaUloga iu)
        {

            Uloga = iu.Uloga;
            JMBGZaposlenog = iu.Zaposleni.JMBG;
            Datum_Od = iu.Datum_Od;
            Datum_Do = iu.Datum_Do;

        }
        public virtual string JMBGZaposlenog { get; set; }
        public virtual DateTime Datum_Od { get; set; }
        public virtual DateTime? Datum_Do { get; set; }
        public virtual string Uloga { get; set; }

    }
}
