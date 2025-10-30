using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOIdSertifikata
    {
        public DTOIdSertifikata()
        {
        }
        public DTOIdSertifikata(IdSertifikata ids)
        {

            Naziv = ids.Naziv;
            Institucija = ids.Institucija;
            if (ids.OperativniRadnik != null)
            {
                ImeOperativnogRadnika = ids.OperativniRadnik.Ime;
                PrezimeOperativnogRadnika = ids.OperativniRadnik.Prezime;
                JMBGOperativnogRadnika = ids.OperativniRadnik.JMBG;

            }

        }
        public virtual string JMBGOperativnogRadnika { get; set; }
        public virtual string ImeOperativnogRadnika { get; set; }
        public virtual string PrezimeOperativnogRadnika { get; set; }
        public virtual int Id { get; set; }

        public virtual string Naziv { get; set; }
        public virtual string Institucija { get; set; }


    }
    public class DTODodajIdSertifikata
    {
        public DTODodajIdSertifikata()
        {

        }

        public DTODodajIdSertifikata(IdSertifikata ids)
        {
            Naziv = ids.Naziv;
            Institucija = ids.Institucija;
            JMBGRadnika = ids.OperativniRadnik.JMBG;

        }
        public virtual string Naziv { get; set; }
        public virtual string Institucija { get; set; }
        public virtual string JMBGRadnika { get; set; }


      


    }

   
}
