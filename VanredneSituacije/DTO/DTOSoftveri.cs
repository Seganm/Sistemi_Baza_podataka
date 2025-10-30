using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOSoftveri
    {
        public DTOSoftveri()
        {

        }

        public DTOSoftveri(Softveri soft)
        {
            JMBGAnaliticara = soft.Analiticar.JMBG;
            ImeAnaliticara = soft.Analiticar.Ime;
            PrezimeAnaliticara = soft.Analiticar.Prezime;
            Id = soft.Id;
            Naziv = soft.Naziv;
        }

        public virtual string JMBGAnaliticara { get; set; }
        public virtual string ImeAnaliticara { get; set; }

        public virtual string PrezimeAnaliticara { get; set; }
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }

      
    }

    public class DTODodajSoftver
    {
        public DTODodajSoftver() { }
        public DTODodajSoftver(Softveri soft)
        {
            Naziv = soft.Naziv;
            JMBG_Analiticar = soft.Analiticar.JMBG;

        }
        public virtual string Naziv { get; set; }
        public virtual string JMBG_Analiticar { get; set; }
    }
}
