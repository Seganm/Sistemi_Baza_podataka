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
            Vanredna_Sit = new DTOVanrednaSituacija(sa.Vanredna_Sit);
        }
        public virtual DTOSluzba Sektor { get; set; }

        public virtual DTOVanrednaSituacija Vanredna_Sit { get; set; }
        public virtual int Id { get; set; }
        public string Uloga { get; set; }


        

    }

    public class DTOSaradnjaDodajj
    {
        public DTOSaradnjaDodajj() { }
        public DTOSaradnjaDodajj(Saradnja sa)
        {
 
            Uloga = sa.Uloga;
            SektorID = sa.Sektor.SektorrId;
            IDVanSituacije = sa.Vanredna_Sit.Id;
        }
        public string Uloga { get; set; }
        public virtual int IDVanSituacije { get; set; }
        public virtual int SektorID { get; set; }


      
    }

    public class DTOSaradnjeVratiPoId
    {
        public DTOSaradnjeVratiPoId() { }
        public DTOSaradnjeVratiPoId(Saradnja sa)
        {
            Id = sa.Id;
            SektorID = sa.Sektor.SektorrId;
            IDVanSituacije = sa.Vanredna_Sit.Id;
            TipVs = sa.Vanredna_Sit.Tip;
            NazivSluzbe = sa.Sektor.TipSektora;

            Uloga = sa.Uloga;
        }
        public virtual int Id { get; set; }
        public virtual string NazivSluzbe { get; set; }
        public virtual string TipVs { get; set; }
        public string Uloga { get; set; }
        public virtual int SektorID { get; set; }

        public virtual int IDVanSituacije { get; set; }


        
    }
}
