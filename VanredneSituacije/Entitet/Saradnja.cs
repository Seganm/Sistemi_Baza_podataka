using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Saradnja
    {

        public virtual int Id { get; set; }
        public virtual VanrednaSituacija VandrednaSituacija { get; set; }
        public virtual Sluzba Sektor { get; set; }
        public virtual string Uloga { get; set; }
    }

}
