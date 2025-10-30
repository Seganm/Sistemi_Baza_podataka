using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
   
    public abstract class Oprema
    {
        public virtual InterventnaJedinica Jedinica { get; set; }
        public virtual StatusOpreme Status { get; set; }

        public virtual DateTime DatumNabavke { get; set; }
        public virtual string Serijski_Broj { get; set; }
        public virtual string Naziv { get; set; }
    }
    public class Zaliha : Oprema
    {
        public Zaliha() : base()
        {
        }
        public virtual int Kolicina { get; set; }
        public virtual TipZalihe Tip { get; set; }
       
    }

    public class LicnaZastita : Oprema
    {
        public virtual TipLicneZastite Tip { get; set; }
    }
    public class Tehnicka : Oprema
    {
        public virtual TipTehnicke Tip { get; set; }
    }
    public class Medicinska : Oprema
    {
        public virtual TipMedicinske Tip { get; set; }
    }
    public enum TipTehnicke
    {
        Pumpa, Detektor, Radio_stanica
    }
    public enum StatusOpreme
    {
        Ispravno,
        Neispravno,
        Servis
    }
    public enum TipZalihe
    {
        Sator, Hrana, Voda, Lekovi
    }
    public enum TipLicneZastite
    {
        Odelo,
        Maska,
        Kaciga
    }
    public enum TipMedicinske
    {
        Prenosive_nosiljka, Defibrilator, Komplet_za_reanimaciju
    }

   
}
