using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{

    public class DTOSluzba
    {
        public DTOSluzba()
        {
        }

        public DTOSluzba(Sluzba sl)
        {
            if (sl.Predstavnik != null)
            {
                Predstavnik = new DTOPredstavnikSluzbe(sl.Predstavnik);
            }
            SektorrId = sl.SektorrId;
            TipSektora = sl.TipSektora;
         
        }
        public DTOPredstavnikSluzbe? Predstavnik { get; set; }
        public virtual int SektorrId { get; set; }
        public virtual string TipSektora { get; set; }




        
    }
    public class DTOVratiSluzbu
    {

        public DTOVratiSluzbu()
        {
        }

        public DTOVratiSluzbu(Sluzba sl)
        {
            SektorrId = sl.SektorrId;
            TipSektora = sl.TipSektora;
            if (sl.Predstavnik != null)
            {
                JMBGPredstavnika = sl.Predstavnik.JMBG;
                ImePredstavnika = sl.Predstavnik.Ime;
                PrezimePredstavnika = sl.Predstavnik.Prezime;
            }
        }
        public string JMBGPredstavnika { get; set; }
        public string ImePredstavnika { get; set; }
        public virtual string TipSektora { get; set; }
        public string PrezimePredstavnika { get; set; }
        public virtual int SektorrId { get; set; }





    }
    public class DTODodajSluzbu
    {
        public DTODodajSluzbu() { }
        public DTODodajSluzbu(Sluzba sl)
        {
            if (sl.Predstavnik != null)
                JMBG_Predstavnik = sl.Predstavnik.JMBG;
            TipSektora = sl.TipSektora;

        }
        public virtual string TipSektora { get; set; }
        public virtual string JMBG_Predstavnik { get; set; }

    }
    public class DTOPregledSluzbe
    {
        public DTOPregledSluzbe() { }
        public DTOPregledSluzbe(Sluzba s)
        {

            TipSektora = s.TipSektora;
        }
        public virtual string TipSektora { get; set; }
     
    }

   

  
}
