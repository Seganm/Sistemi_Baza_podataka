using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Specijalno : Vozilo
    {

        public virtual Namena Namena { get; set; }
    }
    public enum Namena
    {
        Za_vodu,
        Za_hemiju,
        Za_sator,
        Mobilna_laboratorija
    }
}
