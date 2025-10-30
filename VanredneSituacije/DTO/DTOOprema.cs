using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOOprema
    {
        public DTOOprema()
        {
        }

        public DTOOprema(Oprema opr)
        {
            Jedinica = new DTOInterventnaJedinica(opr.Jedinica);
            Naziv = opr.Naziv;
            Serijski_Broj = opr.Serijski_Broj;

            Status = opr.Status;
            DatumNabavke = opr.DatumNabavke;

        }

        
        public virtual DTOInterventnaJedinica Jedinica { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Serijski_Broj { get; set; }


        public virtual StatusOpreme Status { get; set; }

        public virtual DateTime DatumNabavke { get; set; }
    }

    public class DTODodajOpremu
    {
        public DTODodajOpremu() { }
        public DTODodajOpremu(Oprema opr)
        {
            Naziv = opr.Naziv;
            JedinicaID = opr.Jedinica.Jedinstveni_Broj;
            Serijski_Broj = opr.Serijski_Broj;
           
            Status = opr.Status;
            DatumNabavke = opr.DatumNabavke;
            
        }
        public virtual string Naziv { get; set; }
        public virtual int JedinicaID { get; set; }
        public virtual string Serijski_Broj { get; set; }

        public virtual StatusOpreme Status { get; set; }
        public virtual DateTime DatumNabavke { get; set; }



    }
    public class DTOPregledOpreme
    {
        public DTOPregledOpreme() { }
        public DTOPregledOpreme(Oprema opr)
        {
            Naziv = opr.Naziv;
            Status = opr.Status.ToString();
            DatumNabavke = opr.DatumNabavke;

        }
        public virtual string Naziv { get; set; }
        public virtual string Serijski_Broj { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime DatumNabavke { get; set; }
    }
    public class DTOIzmeniOpremu
    {
        public DTOIzmeniOpremu() { }
        public DTOIzmeniOpremu(Oprema opr)
        {
            JedinicaID = opr.Jedinica.Jedinstveni_Broj;
            Naziv = opr.Naziv;
            Status = opr.Status;
            DatumNabavke = opr.DatumNabavke;
            
        }
        public virtual int JedinicaID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual StatusOpreme Status { get; set; }
        public virtual DateTime DatumNabavke { get; set; }


       
    }

   
}
