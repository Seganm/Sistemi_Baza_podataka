using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOSertifikat
    {
        public virtual DTODodajIdSertifikata Id { get; set; }
        public DTOSertifikat()
        {
            Id = new DTODodajIdSertifikata();
        }

        public DTOSertifikat(Sertifikati s)
        {
            Id = new DTODodajIdSertifikata
            {
                Naziv = s.Id.Naziv,
                Institucija = s.Id.Institucija,
                JMBGRadnika = s.Id.OperativniRadnik.JMBG

            };
            DatumIzdavanja = s.DatumIzdavanja;
            DatumVazenja = s.DatumVazenja;
        }
        public virtual DateTime DatumIzdavanja { get; set; }
        public virtual DateTime? DatumVazenja { get; set; }



       
    }

    public class DTOVratiSertifikat
    {
        public DTOVratiSertifikat()
        {

        }

        public DTOVratiSertifikat(Sertifikati s)
        {
            Naziv = s.Id.Naziv;
            JMBGOperativnogRadnika = s.Id.OperativniRadnik.JMBG;
           
          
            DatumIzdavanja = s.DatumIzdavanja;
            DatumVazenja = s.DatumVazenja;
            Institucija = s.Id.Institucija;
        }
        public virtual string Naziv { get; set; }
        public virtual string JMBGOperativnogRadnika { get; set; }
        public virtual DateTime DatumIzdavanja { get; set; }
        public virtual DateTime? DatumVazenja { get; set; }
        public virtual string Institucija { get; set; }


       
    }
}
