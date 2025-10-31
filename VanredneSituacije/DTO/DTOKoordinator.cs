using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOKoordinator : DTOZaposleni
    {

       
        public DTOKoordinator()
        {
        }


        public DTOKoordinator(Koordinator koo) : base(koo)
        {
            BrTimova = koo.BrTimova;
        }
        public virtual int BrTimova { get; set; }
    }

    public class DTOPregledKoordinator
    {
        public DTOPregledKoordinator() 
        {
        }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string JMBG { get; set; }

      
        public DTOPregledKoordinator(Koordinator koo)
        {
            Ime = koo.Ime;
            Prezime = koo.Prezime;
            JMBG = koo.JMBG;
        }
    }


    public class DTOIzmeniKoordinatora : DTOIzmeniZaposlenog
    {

        
        public DTOIzmeniKoordinatora()
        {
        }


        public DTOIzmeniKoordinatora(Koordinator koo) : base(koo)
        {
            BrTimova = koo.BrTimova;
        }
        public virtual int BrTimova { get; set; }
    }

}
