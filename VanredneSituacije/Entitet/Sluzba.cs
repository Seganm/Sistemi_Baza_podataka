using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Sluzba
    {
        public virtual int Id_Sektora { get; set; }
        public virtual IList<Saradnja> VandredneSituacije { get; set; }
        public virtual string TipSektora { get; set; }

        public virtual PredstavnikSluzbe? Predstavnik { get; set; }

       
       

        public Sluzba()
        {
            VandredneSituacije = new List<Saradnja>();
        }
    }
}
