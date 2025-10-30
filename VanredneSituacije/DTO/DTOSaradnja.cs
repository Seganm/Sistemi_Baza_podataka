using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOSaradnja
    {
        public DTOSaradnja()
        {
        }

        public DTOSaradnja(Saradnja sa)
        {
            Id = sa.Id;
            Uloga = sa.Uloga;
            Sektor = new DTOSluzba(sa.Sektor);
            VandrednaSituacija = new DTOVanrednaSituacija(sa.VandrednaSituacija);
        }
        public virtual DTOSluzba Sektor { get; set; }

        public virtual DTOVanrednaSituacija VandrednaSituacija { get; set; }
        public virtual int Id { get; set; }
        public string Uloga { get; set; }


        

    }

    public class DTODodajSaradnju
    {
        public DTODodajSaradnju() { }
        public DTODodajSaradnju(Saradnja sa)
        {
 
            Uloga = sa.Uloga;
            SektorID = sa.Sektor.Id_Sektora;
            VanrednaSituacijaID = sa.VandrednaSituacija.Id;
        }
        public string Uloga { get; set; }
        public virtual int VanrednaSituacijaID { get; set; }
        public virtual int SektorID { get; set; }


      
    }

    public class DTOVratiSaradnju
    {
        public DTOVratiSaradnju() { }
        public DTOVratiSaradnju(Saradnja sa)
        {
            Id = sa.Id;
            SektorID = sa.Sektor.Id_Sektora;
            VanrednaSituacijaID = sa.VandrednaSituacija.Id;
            TipVs = sa.VandrednaSituacija.Tip;
            NazivSluzbe = sa.Sektor.TipSektora;

            Uloga = sa.Uloga;
        }
        public virtual int Id { get; set; }
        public virtual string NazivSluzbe { get; set; }
        public virtual string TipVs { get; set; }
        public string Uloga { get; set; }
        public virtual int SektorID { get; set; }

        public virtual int VanrednaSituacijaID { get; set; }


        
    }
}
