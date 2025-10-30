using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Ekspertize
    {
        public virtual int Id { get; set; }
        public virtual String Oblast { get; set; }
        public virtual Analiticar Analiticar { get; set; }
    }
}
