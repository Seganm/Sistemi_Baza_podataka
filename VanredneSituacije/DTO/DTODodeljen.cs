using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTODodeljen
    {
        public DTODodeljen()
        {
        }

        public DTODodeljen(Dodeljen dod)
        {
            Id = dod.Id;
            DatumOd = dod.DatumOd;
            DatumDo = dod.DatumDo;
            if (dod.Radnik != null)
                Radnik = new DTOOperativniRadnik(dod.Radnik);
            if (dod.Jedinica != null)
                Jedinica = new DTOInterventnaJedinica(dod.Jedinica);
            if (dod.Vozilo != null)
                Vozilo = new DTOVozilo(dod.Vozilo);


        }
        public virtual int Id { get; set; }
        public virtual DateTime DatumOd { get; set; }

        public virtual DateTime? DatumDo { get; set; }

        public virtual DTOOperativniRadnik? Radnik { get; set; }
        public virtual DTOInterventnaJedinica? Jedinica { get; set; }
        public virtual DTOVozilo Vozilo { get; set; }




    }

    public class DTODodajDodeljen
    {
        public DTODodajDodeljen()
        {
        }

        public DTODodajDodeljen(Dodeljen dod)
        {
            DatumOd = dod.DatumOd;
            DatumDo = dod.DatumDo;
            if (dod.Jedinica != null)
            {
                IdJedinica = dod.Jedinica.JedinstveniBroj;
            }
            if (dod.Radnik != null)
            {
                JMBGRadnik = dod.Radnik.JMBG;
            }
  
            RegVozilo = dod.Vozilo.Registracijaa;
           

        }
        public virtual string? JMBGRadnik { get; set; }
        public virtual int? IdJedinica { get; set; }
        public virtual DateTime DatumOd { get; set; }

        public virtual DateTime? DatumDo { get; set; }
        public virtual string RegVozilo { get; set; }

       
    }

    public class DTOVratiDodeljen
    {
        public DTOVratiDodeljen()
        {
        }

        public DTOVratiDodeljen(Dodeljen dod)
        {

            Id = dod.Id;
            DatumOd = dod.DatumOd;
            DatumDo = dod.DatumDo;
            if (dod.Jedinica != null)
            {
                IdJedinica = dod.Jedinica.JedinstveniBroj;
                NazivJedinice = dod.Jedinica.Naziv;
            }
            if (dod.Radnik != null)
            {
                ImeRadnika = dod.Radnik.Ime;
                PrezimeRadnika = dod.Radnik.Prezime;
                JMBGRadnik = dod.Radnik.JMBG;

            }

            RegVozilo = dod.Vozilo.Registracijaa;
        }
        public virtual int Id { get; set; }

        public virtual int? IdJedinica { get; set; }

        public virtual string NazivJedinice { get; set; }
        public virtual DateTime DatumOd { get; set; }

        public virtual DateTime? DatumDo { get; set; }
        public virtual string RegVozilo { get; set; }
        public virtual string? JMBGRadnik { get; set; }

        public string PunoIme => ImeRadnika + " " + PrezimeRadnika;
        public virtual string? ImeRadnika { get; set; }
        public virtual string? PrezimeRadnika { get; set; }

    }
}
