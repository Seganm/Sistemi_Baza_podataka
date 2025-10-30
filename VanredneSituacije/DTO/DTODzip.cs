using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTODodajDzip : DTODodajVozilo
    {
        public DTODodajDzip()
        { 
            
        }

        public DTODodajDzip(Vozilo vo) : base(vo) 
        {
        }
    }

   
    public class DTODzip : DTOVozilo
    {
        public DTODzip() 
        { 
        }

        public DTODzip(Vozilo vo) : base(vo)
        { 
        }
    }
    public class DTOIzmeniDzip : DTOIzmeniVozilo
    {
        public DTOIzmeniDzip()
        {
        }

        public DTOIzmeniDzip(Vozilo vo) : base(vo)
        {
        }
    }

}
