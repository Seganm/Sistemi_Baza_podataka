using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class OperativniRadnik : Zaposleni
    {

        public virtual InterventnaJedinica? InterventnaJedinica { get; set; }
        public virtual Spremnost Fizicka_Spremnost { get; set; }

        public virtual IList<Dodeljen> Dodeljuje { get; set; }
        public virtual IList<Sertifikati> Sertifikats { get; set; }
        public virtual int Broj_Sati { get; set; }

        public OperativniRadnik()
        {
            Dodeljuje = new List<Dodeljen>();
            Sertifikats = new List<Sertifikati>();
        }
    }
    public enum Spremnost { Visoka, Srednja, Niska }
}
