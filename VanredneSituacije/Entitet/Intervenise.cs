using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Intervenise
    {
        public virtual int Id { get; set; }
        public virtual Intervencija IdIntervencije { get; set; }

        public virtual VanrednaSituacija IdVandredneSituacije { get; set; }
        public virtual InterventnaJedinica IdInterventneJed { get; set; }
        

      
    }
}
