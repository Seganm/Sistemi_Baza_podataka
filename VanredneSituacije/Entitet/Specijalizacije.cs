using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Specijalizacije
    {
        public virtual int Id { get; set; }
        public virtual string Tip { get; set; }
        public virtual Koordinator Koordinator { get; set; }
    }
}
