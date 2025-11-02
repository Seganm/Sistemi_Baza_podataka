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
            DatIzdavanje = s.DatIzdavanje;
            DatVazenje = s.DatVazenje;
        }
        public virtual DateTime DatIzdavanje { get; set; }
        public virtual DateTime? DatVazenje { get; set; }



       
    }

    public class DTOSertifikatVratii
    {
        public DTOSertifikatVratii()
        {

        }

        public DTOSertifikatVratii(Sertifikati s)
        {
            Naziv = s.Id.Naziv;
            JMBGOperativnogRadnika = s.Id.OperativniRadnik.JMBG;
           
          
            DatIzdavanje = s.DatIzdavanje;
            DatVazenje = s.DatVazenje;
            Institucija = s.Id.Institucija;
        }
        public virtual string Naziv { get; set; }
        public virtual string JMBGOperativnogRadnika { get; set; }
        public virtual DateTime DatIzdavanje { get; set; }
        public virtual DateTime? DatVazenje { get; set; }
        public virtual string Institucija { get; set; }


       
    }
}
