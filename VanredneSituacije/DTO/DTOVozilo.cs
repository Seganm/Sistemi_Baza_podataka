using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOVozilo
    {
        public DTOVozilo()
        {

        }
        public DTOVozilo(Vozilo v)
        {
            Registarska_Oznaka = v.Registarska_Oznaka;
            Proizvodjac = v.Proizvodjac;
            Status = v.Status;
            Lokacija = v.Lokacija;
        }
        public virtual string Lokacija { get; set; }
        public virtual string Proizvodjac { get; set; }

        public virtual StatusVozila Status { get; set; }
        public virtual string Registarska_Oznaka { get; set; }








    }
    public class DTODodajVozilo
    {
        public DTODodajVozilo()
        {
        }
        public DTODodajVozilo(Vozilo vo)
        {
            Registarska_Oznaka = vo.Registarska_Oznaka;
            Proizvodjac = vo.Proizvodjac;
            Status = vo.Status;
            Lokacija = vo.Lokacija;

        }
        public virtual string Registarska_Oznaka { get; set; }
        public virtual string Proizvodjac { get; set; }

        public virtual StatusVozila Status { get; set; }
        public virtual string Lokacija { get; set; }

    }


   

    public class DTOIzmeniVozilo
    {
        public DTOIzmeniVozilo()
        {
        }
        public DTOIzmeniVozilo(Vozilo vo)
        {
            Lokacija = vo.Lokacija;
            Proizvodjac = vo.Proizvodjac;
            Status = vo.Status;

        }
        public virtual string Lokacija { get; set; }
        public virtual string Proizvodjac { get; set; }

        public virtual StatusVozila Status { get; set; }



     


    }
}
