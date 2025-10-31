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
            DatumPoc = a.DatumPoc;
            DatumKraj = a.DatumKraj;
            Vozilo = new DTOVozilo(a.Vozilo);
            Intervencija = new DTOIntervencija(a.Intervencija);

        }
        public virtual int ID { get; set; }
        public virtual DateTime DatumPoc { get; set; }
        public virtual DateTime? DatumKraj { get; set; }
        public virtual DTOVozilo Vozilo { get; set; }
        public virtual DTOIntervencija Intervencija { get; set; }



       
    }
    public class DTOVratiAngazovano
    {
        public DTOVratiAngazovano() { }
        public DTOVratiAngazovano(Angazovano a)
        {
            Id = a.ID;
            DatumPoc = a.DatumPoc;
            DatumKraj = a.DatumKraj;
            VoziloReg = a.Vozilo.Registarska_Oznaka;
            IntervencijaID = a.Intervencija.Id;


        }
        public virtual int Id { get; set; }
        public virtual DateTime DatumPoc { get; set; }

        public virtual DateTime? DatumKraj { get; set; }
        public virtual string VoziloReg { get; set; }
        public virtual int IntervencijaID { get; set; }




    }
    public class DTODodajAngazovano
    {
        public DTODodajAngazovano() { }
        public DTODodajAngazovano(Angazovano a)
        {
            DatumPoc = a.DatumPoc;
            DatumKraj = a.DatumKraj;
            VoziloReg = a.Vozilo.Registarska_Oznaka;
            IntervencijaID = a.Intervencija.Id;
 

        }
        public virtual DateTime DatumPoc { get; set; }

        public virtual DateTime? DatumKraj { get; set; }
        public virtual string VoziloReg { get; set; }
        public virtual int IntervencijaID { get; set; }



       
    }

    
}
