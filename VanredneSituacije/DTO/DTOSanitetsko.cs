using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTODodajSanitetsko : DTODodajVozilo
    {
        public DTODodajSanitetsko() { }

        public DTODodajSanitetsko(Vozilo vo) : base(vo) { }
    }
    public class DTOSanitetsko : DTOVozilo
    {
        public DTOSanitetsko() { }

        public DTOSanitetsko(Vozilo vo) : base(vo) { }
    }
    public class DTOIzmeniSanitetsko : DTOIzmeniVozilo
    {
        public DTOIzmeniSanitetsko() { }

        public DTOIzmeniSanitetsko(Vozilo vo) : base(vo) { }
    }
   

  
}
