using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOSpecijalizacije
    {
        public DTOSpecijalizacije()
        {
        }

        public DTOSpecijalizacije(Specijalizacije spec)
        {
           
            JMBGKoordinatoraa = spec.Koordinator.JMBG;
            Id = spec.Id;
            Tip = spec.Tip;
            ImeKoordinatora = spec.Koordinator.Ime;
            PrezimeKoordinatora = spec.Koordinator.Prezime;

        }

        public virtual string JMBGKoordinatoraa { get; set; }
        public virtual int Id { get; set; }

        public virtual string Tip { get; set; }

        public virtual string ImeKoordinatora { get; set; }

        public virtual string PrezimeKoordinatora { get; set; }


       
    }

    public class DTOSpecijalizacijaDodajj
    {
        public DTOSpecijalizacijaDodajj() { }
        public DTOSpecijalizacijaDodajj(Specijalizacije spec)
        {
            JMBGKoordinatora = spec.Koordinator.JMBG;
            Tip = spec.Tip;
        }
        public virtual string Tip { get; set; }
        public virtual string JMBGKoordinatora { get; set; }


       
    }
}
