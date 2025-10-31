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
            JMBGZap = iu.Zaposleni.JMBG;
            Id = iu.Id;
            DatumPoc = iu.DatumPoc;
            DatumKraj = iu.DatumKraj;
            Uloga = iu.Uloga;
        }
        public virtual string JMBGZap { get; set; }
        public virtual int Id { get; set; }
        public virtual DateTime DatumPoc { get; set; }
        public virtual DateTime? DatumKraj { get; set; }

        public virtual string Uloga { get; set; }



    }
    public class DTOIstorijaDodajj
    {
        public DTOIstorijaDodajj() { 
        }
        public DTOIstorijaDodajj(IstorijaUloga iu)
        {

            Uloga = iu.Uloga;
            JMBGZap = iu.Zaposleni.JMBG;
            DatumPoc = iu.DatumPoc;
            DatumKraj = iu.DatumKraj;

        }
        public virtual string JMBGZap { get; set; }
        public virtual DateTime DatumPoc { get; set; }
        public virtual DateTime? DatumKraj { get; set; }
        public virtual string Uloga { get; set; }

    }
}
