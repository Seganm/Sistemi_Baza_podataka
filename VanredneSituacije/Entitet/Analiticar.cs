using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Analiticar : Zaposleni
    {
        public Analiticar()
        {
            Softveri = new List<Softveri>();
            Ekspertiza = new List<Ekspertize>();
        }
        public virtual IList<Ekspertize> Ekspertiza { get; set; }
        public virtual IList<Softveri> Softveri { get; set; }
        
        
    }
}
