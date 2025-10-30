using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOAngazovano
    {
        public DTOAngazovano() { }

        public DTOAngazovano(Angazovano a)
        {
            ID = a.ID;
            Datum_Od = a.Datum_Od;
            Datum_Do = a.Datum_Do;
            Vozilo = new DTOVozilo(a.Vozilo);
            Intervencija = new DTOIntervencija(a.Intervencija);

        }
        public virtual int ID { get; set; }
        public virtual DateTime Datum_Od { get; set; }
        public virtual DateTime? Datum_Do { get; set; }
        public virtual DTOVozilo Vozilo { get; set; }
        public virtual DTOIntervencija Intervencija { get; set; }



       
    }
    public class DTOVratiAngazovano
    {
        public DTOVratiAngazovano() { }
        public DTOVratiAngazovano(Angazovano a)
        {
            Id = a.ID;
            Datum_Od = a.Datum_Od;
            Datum_Do = a.Datum_Do;
            VoziloReg = a.Vozilo.Registarska_Oznaka;
            IntervencijaID = a.Intervencija.Id;


        }
        public virtual int Id { get; set; }
        public virtual DateTime Datum_Od { get; set; }

        public virtual DateTime? Datum_Do { get; set; }
        public virtual string VoziloReg { get; set; }
        public virtual int IntervencijaID { get; set; }




    }
    public class DTODodajAngazovano
    {
        public DTODodajAngazovano() { }
        public DTODodajAngazovano(Angazovano a)
        {
            Datum_Od = a.Datum_Od;
            Datum_Do = a.Datum_Do;
            VoziloReg = a.Vozilo.Registarska_Oznaka;
            IntervencijaID = a.Intervencija.Id;
 

        }
        public virtual DateTime Datum_Od { get; set; }

        public virtual DateTime? Datum_Do { get; set; }
        public virtual string VoziloReg { get; set; }
        public virtual int IntervencijaID { get; set; }



       
    }

    
}
