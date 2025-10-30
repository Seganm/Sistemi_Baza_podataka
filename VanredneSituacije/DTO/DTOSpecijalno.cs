using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOSpecijalno : DTOVozilo
    {
 

        public DTOSpecijalno() { }

        public DTOSpecijalno(Specijalno spec) : base(spec)
        {
            Namena = spec.Namena;
        }
        public virtual Namena Namena { get; set; }
    }
    public class DTODodajSpecijalno : DTODodajVozilo
    {


        public DTODodajSpecijalno() { }

        public DTODodajSpecijalno(Specijalno spec) : base(spec)
        {
            Namena = spec.Namena;
        }
        public virtual Namena Namena { get; set; }
    }
    public class DTOIzmeniSpecijalno : DTOIzmeniVozilo
    {

        public DTOIzmeniSpecijalno() { }

        public DTOIzmeniSpecijalno(Specijalno spec) : base(spec)
        {
            Namena = spec.Namena;
        }
        public virtual Namena Namena { get; set; }

    }

    
}
