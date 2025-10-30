using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOIntervencija
    {
        public DTOIntervencija()
        {

        }

        public DTOIntervencija(Intervencija intv)
        {
            Lokacija = intv.Lokacija;
            Id = intv.Id;
            Resursi = intv.Resursi;
            Broj_Spasenih = intv.Broj_Spasenih;
            Broj_Povredjenih = intv.Broj_Povredjenih;
            Status = intv.Status.ToString();

            Uspesnost = intv.Uspesnost;

            Datum_I_Vreme = intv.Datum_I_Vreme;
        }
        public virtual string Lokacija { get; set; }
        public virtual int Id { get; set; }
        public virtual string Resursi { get; set; }
        public virtual int Broj_Spasenih { get; set; }
        public virtual int Broj_Povredjenih { get; set; }



        public virtual string Status { get; set; }


        public virtual int Uspesnost { get; set; }
        public virtual DateTime Datum_I_Vreme { get; set; }


    }
    public class DTOOsnovnaIntervencija
    {
        public DTOOsnovnaIntervencija() { }
        public DTOOsnovnaIntervencija(Intervencija intv)
        {
            Lokacija = intv.Lokacija;
            Resursi = intv.Resursi;
            Broj_Spasenih = intv.Broj_Spasenih;
            Broj_Povredjenih = intv.Broj_Povredjenih;


            Status = intv.Status;

            Uspesnost = intv.Uspesnost;
            Datum_I_Vreme = intv.Datum_I_Vreme;
        }
        public virtual string Lokacija { get; set; }
        public virtual string Resursi { get; set; }
        public virtual int Broj_Spasenih { get; set; }
        public virtual int Broj_Povredjenih { get; set; }


        public virtual Status Status { get; set; }


        public virtual int Uspesnost { get; set; }
        public virtual DateTime Datum_I_Vreme { get; set; }


    }
}
