using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Koordinator : Zaposleni    
    {
        public Koordinator()
        {
            Specijalizacija = new List<Specijalizacije>();
        }
        public virtual IList<Specijalizacije> Specijalizacija { get; set; }
        public virtual int BrTimova { get; set; }


    }
}
