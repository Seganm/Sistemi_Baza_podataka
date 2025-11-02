using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOInterventnaJedinica
    {
        public DTOInterventnaJedinica()
        { 
        }

        public DTOInterventnaJedinica(InterventnaJedinica i)
        {
            if (i.Komandir != null)
            {
                JMBGKomandira = i.Komandir.JMBG;
            }
            BrojClanova = 0;
            Baza = i.Baza;
            Naziv = i.Naziv;
        }
        public virtual string? JMBGKomandira { get; set; }
        public virtual int BrojClanova { get; set; }
        public virtual string Baza { get; set; }
        public virtual string Naziv { get; set; }

    }
    public class DTOVratiInterventnuJedinicu
    {
        public DTOVratiInterventnuJedinicu()
        {

        }

        public DTOVratiInterventnuJedinicu(InterventnaJedinica i)
        {
            Naziv = i.Naziv;
            JedinstveniBroj = i.JedinstveniBroj;
            Baza = i.Baza;
            BrojClanova = i.BrojClanova;
            if (i.Komandir != null)
            {
                ImeKomandira = i.Komandir.Ime;
                PrezimeKomandira = i.Komandir.Prezime;
                JMBGKomandira = i.Komandir.JMBG;


            }
        }
        public virtual string? ImeKomandira { get; set; }

        public virtual string? PrezimeKomandira { get; set; }
        public virtual string? JMBGKomandira { get; set; }
        public virtual int JedinstveniBroj { get; set; }
        public virtual string Naziv { get; set; }

        public virtual string Baza { get; set; }


        public virtual int BrojClanova { get; set; }
    }
    public class DTOOsnovnaInterventnaJedinica
    {
        public DTOOsnovnaInterventnaJedinica()
        {
        }
        public DTOOsnovnaInterventnaJedinica(InterventnaJedinica i)
        {
            if (i.Komandir != null)
                JMBGKomandira = i.Komandir.JMBG;
            Baza = i.Baza;
            Naziv = i.Naziv;
        }
        public virtual string JMBGKomandira { get; set; }
        public virtual string Baza { get; set; }
        public virtual string Naziv { get; set; }

    
        
    }


}
