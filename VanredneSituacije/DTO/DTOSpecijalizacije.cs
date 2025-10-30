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
           
            JMBG_Kordinatora = spec.Kordinator.JMBG;
            Id = spec.Id;
            Tip = spec.Tip;
            ImeKordinatora = spec.Kordinator.Ime;
            PrezimeKordinatora = spec.Kordinator.Prezime;

        }

        public virtual string JMBG_Kordinatora { get; set; }
        public virtual int Id { get; set; }

        public virtual string Tip { get; set; }

        public virtual string ImeKordinatora { get; set; }

        public virtual string PrezimeKordinatora { get; set; }


       
    }

    public class DTODodajSpecijalizaciju
    {
        public DTODodajSpecijalizaciju() { }
        public DTODodajSpecijalizaciju(Specijalizacije spec)
        {
            JMBG_Kordinator = spec.Kordinator.JMBG;
            Tip = spec.Tip;
        }
        public virtual string Tip { get; set; }
        public virtual string JMBG_Kordinator { get; set; }


       
    }
}
