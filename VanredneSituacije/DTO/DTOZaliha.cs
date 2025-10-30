using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOZaliha : DTOOprema
    {

        public virtual string Tip { get; set; }
        public virtual int Kolicina { get; set; }

        public DTOZaliha() { }
        public DTOZaliha(Zaliha zal) : base(zal)
        {
            Tip = zal.Tip.ToString();
            Kolicina = zal.Kolicina;
        }

    }
    public class DTOPregledZalihe : DTOPregledOpreme
    {



        public DTOPregledZalihe() { }
        public DTOPregledZalihe(Zaliha zal) : base(zal)
        {
            Tip = zal.Tip.ToString();
            Kolicina = zal.Kolicina;
        }
        public virtual string Tip { get; set; }
        public virtual int Kolicina { get; set; }
    }
}
public class DTODodajZalihe : DTODodajOpremu
    {

    

        public DTODodajZalihe() { }
        public DTODodajZalihe(Zaliha zal) : base(zal)
        {
            Tip = zal.Tip;
            Kolicina = zal.Kolicina;
        }
        public virtual TipZalihe Tip { get; set; }
        public virtual int Kolicina { get; set; }
    }

    public class DTOIzmeniZalihe : DTOIzmeniOpremu
    {

       
        public DTOIzmeniZalihe() { }
        public DTOIzmeniZalihe(Zaliha zal) : base(zal)
        {
            Tip = zal.Tip;
            Kolicina = zal.Kolicina;
        }
        public virtual TipZalihe Tip { get; set; }
        public virtual int Kolicina { get; set; }

    }

    
