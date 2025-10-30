using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOEvidencijaServis
    {
        public DTOEvidencijaServis()
        {
        }
        public DTOEvidencijaServis(EvidencijaServis es)
        {
            if (es.Vozilo != null)
            {
                RegistarskaOznakaVozila = es.Vozilo.Registarska_Oznaka;
                Status = es.Vozilo.Status.ToString();
            }
            Id = es.Id;
            TipServisa = es.TipServisa;
            Datum = es.Datum;

        }

        public virtual DateTime Datum { get; set; }
        public virtual int Id { get; set; }
        public virtual string Status { get; set; }
        public virtual string TipServisa { get; set; }
        public virtual string RegistarskaOznakaVozila { get; set; }


    }
    public class DTODodajEvidencijuServis
    {
        public DTODodajEvidencijuServis()
        {
        }

        public DTODodajEvidencijuServis(EvidencijaServis es)
        {
      
            RegistarskaOznakaVozila = es.Vozilo.Registarska_Oznaka;
            TipServisa = es.TipServisa;
            Datum = es.Datum;

        }
        public virtual string TipServisa { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual string RegistarskaOznakaVozila { get; set; }


      

    }
 
}
