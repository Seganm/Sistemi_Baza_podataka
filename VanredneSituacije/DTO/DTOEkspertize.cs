using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOEkspertize
    {
        public DTOEkspertize()
        {
        }
        public DTOEkspertize(Ekspertize ek)
        {
            JMBGAnaliticara = ek.Analiticar.JMBG;
            ImeAnaliticara = ek.Analiticar.Ime;
            PrezimeAnaliticara = ek.Analiticar.Prezime;

            Id = ek.Id;
            Oblast = ek.Oblast;


        }
        public virtual string JMBGAnaliticara { get; set; }
        public virtual string ImeAnaliticara { get; set; }

        public virtual string PrezimeAnaliticara { get; set; }

        public virtual int Id { get; set; }
 

        public virtual string Oblast { get; set; }


    }
    public class DTOEkspertizaIzmenii
    {



        public DTOEkspertizaIzmenii()
        {
        }

        public DTOEkspertizaIzmenii(Ekspertize e)
        {
            JMBGAnaliticara = e.Analiticar.JMBG;

            Oblast = e.Oblast;
           
        }
        public virtual string JMBGAnaliticara { get; set; }

        public virtual string Oblast { get; set; }
    }
}
