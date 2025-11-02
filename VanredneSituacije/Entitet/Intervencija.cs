using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{

    public class Intervencija
    {
        public Intervencija()
        {
            Ucestvovalos = new List<Angazovano>();
            Ucestvuje = new List<Intervenise>();
        }
        public virtual int Id { get; set; }
        public virtual IList<Intervenise> Ucestvuje { get; set; }

        public virtual IList<Angazovano> Ucestvovalos { get; set; }
        public virtual string Resursi { get; set; }
        public virtual int BrSpasenih { get; set; } = 0;
        public virtual int BrPovredjenih { get; set; } = 0;
        public virtual int Uspesnost { get; set; }
        public virtual DateTime DatumVremee { get; set; }

        public virtual string Lokacija { get; set; }
        public virtual Status Status { get; set; }
    }
    public enum Status
    {
        U_toku, Zavrsena
    }
}
