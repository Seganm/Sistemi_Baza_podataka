using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTODodajKamion : DTODodajVozilo
    {
        public DTODodajKamion() { }
        public DTODodajKamion(Vozilo vo) : base(vo) { }
    }
    public class DTOKamion : DTOVozilo
    {
        public DTOKamion() { }
        public DTOKamion(Vozilo vo) : base(vo) { }
    }

    public class DTOIzmeniKamion : DTOIzmeniVozilo
    {
        public DTOIzmeniKamion() { }
        public DTOIzmeniKamion(Vozilo vo) : base(vo) { }
    }
}
