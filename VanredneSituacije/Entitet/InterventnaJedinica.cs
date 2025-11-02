using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class InterventnaJedinica
    {
        public InterventnaJedinica()
        {
            Dodeljuje = new List<Dodeljen>();
            Radnici = new List<OperativniRadnik>();
            Ucestvuje = new List<Intervenise>();
            Oprema = new List<Oprema>();

        }
        public virtual string Naziv { get; set; }
        public virtual int BrojClanova { get; set; }
        public virtual int JedinstveniBroj { get; set; }
        
        public virtual string Baza { get; set; }
        public virtual IList<OperativniRadnik> Radnici { get; set; }

        public virtual IList<Intervenise> Ucestvuje { get; set; }

        public virtual IList<Dodeljen> Dodeljuje { get; set; }

        public virtual IList<Oprema> Oprema { get; set; }

        public virtual OperativniRadnik? Komandir { get; set; }
    }
    public class SpecijalnaInterventnaJedinica : InterventnaJedinica
    {
        public virtual string SpecijalnaTip { get; set; }
    }
    public class OpstaInterventnaJedinica : InterventnaJedinica { }
}
