﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class PredstavnikSluzbe
    {
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Pozicija { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }

    }
}
