using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOTerensko : DTOVozilo
    {
        public DTOTerensko() { }

        public DTOTerensko(Vozilo vo) : base(vo) { }
    }

    public class DTOIzmeniTerensko : DTOIzmeniVozilo
    {
        public DTOIzmeniTerensko() { }

        public DTOIzmeniTerensko(Vozilo vo) : base(vo) { }
    }
}
