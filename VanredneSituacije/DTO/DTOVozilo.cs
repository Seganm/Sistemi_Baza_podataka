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
            Registracijaa = v.Registracijaa;
            Proizvodjac = v.Proizvodjac;
            Status = v.Status;
            Lokacija = v.Lokacija;
        }
        public virtual string Lokacija { get; set; }
        public virtual string Proizvodjac { get; set; }

        public virtual StatusVozila Status { get; set; }
        public virtual string Registracijaa { get; set; }








    }
    public class DTODodajVozilo
    {
        public DTODodajVozilo()
        {
        }
        public DTODodajVozilo(Vozilo vo)
        {
            Registracijaa = vo.Registracijaa;
            Proizvodjac = vo.Proizvodjac;
            Status = vo.Status;
            Lokacija = vo.Lokacija;

        }
        public virtual string Registracijaa { get; set; }
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
