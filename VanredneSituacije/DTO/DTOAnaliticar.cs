using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOAnaliticar : DTOZaposleni
    {

        public DTOAnaliticar()
        {

        }
        public DTOAnaliticar(Analiticar an) : base(an)
        {
        }
    }
    public class DTOPregledAnaliticar
    {
        public DTOPregledAnaliticar() { }
        public DTOPregledAnaliticar(Analiticar an)
        {
            Ime = an.Ime;
            Prezime = an.Prezime;
            JMBG = an.JMBG;

        }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string JMBG { get; set; }


    }
    public class DTOAnaliticarIzmeniia : DTOIzmeniZaposlenog
    {

        public DTOAnaliticarIzmeniia()
        {

        }
        public DTOAnaliticarIzmeniia(Analiticar a) : base(a)
        {
        }
    }

 
}
