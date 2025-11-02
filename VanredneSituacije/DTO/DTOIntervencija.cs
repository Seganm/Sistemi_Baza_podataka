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
            BrSpasenih = intv.BrSpasenih;
            BrPovredjenih = intv.BrPovredjenih;
            Status = intv.Status.ToString();

            Uspesnost = intv.Uspesnost;

            DatumVremee = intv.DatumVremee;
        }
        public virtual string Lokacija { get; set; }
        public virtual int Id { get; set; }
        public virtual string Resursi { get; set; }
        public virtual int BrSpasenih { get; set; }
        public virtual int BrPovredjenih { get; set; }



        public virtual string Status { get; set; }


        public virtual int Uspesnost { get; set; }
        public virtual DateTime DatumVremee { get; set; }


    }
    public class DTOOsnovnaIntervencija
    {
        public DTOOsnovnaIntervencija() { }
        public DTOOsnovnaIntervencija(Intervencija intv)
        {
            Lokacija = intv.Lokacija;
            Resursi = intv.Resursi;
            BrSpasenih = intv.BrSpasenih;
            BrPovredjenih = intv.BrPovredjenih;


            Status = intv.Status;

            Uspesnost = intv.Uspesnost;
            DatumVremee = intv.DatumVremee;
        }
        public virtual string Lokacija { get; set; }
        public virtual string Resursi { get; set; }
        public virtual int BrSpasenih { get; set; }
        public virtual int BrPovredjenih { get; set; }


        public virtual Status Status { get; set; }


        public virtual int Uspesnost { get; set; }
        public virtual DateTime DatumVremee { get; set; }


    }
}
