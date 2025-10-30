using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class Vozilo
    {
        public Vozilo()
        {
            Ucestvovalo = new List<Angazovano>();
            Dodeljuje = new List<Dodeljen>();
            Servisi = new List<EvidencijaServis>();
        }
        public virtual IList<EvidencijaServis> Servisi { get; set; }

        public virtual IList<Dodeljen> Dodeljuje { get; set; }

        public virtual IList<Angazovano> Ucestvovalo { get; set; }

        public virtual string Registarska_Oznaka { get; set; }

        public virtual string Proizvodjac { get; set; }

        public virtual string Lokacija { get; set; }

        public virtual StatusVozila Status { get; set; }

    }
    public enum StatusVozila
    {
        Operativno, U_kvaru
    }
    public class Sanitetsko : Vozilo
    {
    }
}
