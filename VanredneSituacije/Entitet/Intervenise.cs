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
        public virtual Intervencija IdIntervencijee { get; set; }

        public virtual VanrednaSituacija IdVanrednee { get; set; }
        public virtual InterventnaJedinica IdInterventnee { get; set; }
        

      
    }
}
