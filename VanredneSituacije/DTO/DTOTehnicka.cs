using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOTehnicka : DTOOprema
    {
        public DTOTehnicka() { }
        public DTOTehnicka(Tehnicka teh) : base(teh)
        {
            Tip = teh.Tip.ToString();
        }
        public virtual string Tip { get; set; }

        
    }
    public class DTOPregledTehnicke : DTOPregledOpreme
    {

        public DTOPregledTehnicke() { }

        public DTOPregledTehnicke(Tehnicka teh) : base(teh)
        {
            Tip = teh.Tip.ToString();
        }
        public virtual string Tip { get; set; }
    }
    public class DTODodajTehnicku : DTODodajOpremu
    {
        public DTODodajTehnicku() { }

        public DTODodajTehnicku(Tehnicka teh) : base(teh)
        {
            Tip = teh.Tip;
        }
        public virtual TipTehnicke Tip { get; set; }
       
    }

    public class DTOIzmeniTehnicku : DTOIzmeniOpremu
    {
        public virtual TipTehnicke Tip { get; set; }
        public DTOIzmeniTehnicku() { }

        public DTOIzmeniTehnicku(Tehnicka teh) : base(teh)
        {
            Tip = teh.Tip;
        }
    }

 
}
