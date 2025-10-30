﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Dodeljen
    {
        public virtual int Id { get; set; }
       
        public virtual DateTime DatumOd { get; set; }

        public virtual DateTime? DatumDo { get; set; }
        public virtual Vozilo Vozilo { get; set; }

        public virtual OperativniRadnik? Radnik { get; set; }
        public virtual InterventnaJedinica? Jedinica { get; set; }
    }
}
