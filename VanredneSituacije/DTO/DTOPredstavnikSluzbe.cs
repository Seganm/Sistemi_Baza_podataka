using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOPredstavnikSluzbe
    {
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Pozicija { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }

        public string PunoIme => Ime + " " + Prezime;



        public DTOPredstavnikSluzbe() { }
        public DTOPredstavnikSluzbe(PredstavnikSluzbe p)
        {
            JMBG = p.JMBG;
            Ime = p.Ime;
            Prezime = p.Prezime;
            Pozicija = p.Pozicija;
            Telefon = p.Telefon;
            Email = p.Email;
        }
    }

    public class DTOPredstavnikSluzbeIzmeniiSluzbe
    {

        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Pozicija { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }



        public DTOPredstavnikSluzbeIzmeniiSluzbe() { }
        public DTOPredstavnikSluzbeIzmeniiSluzbe(PredstavnikSluzbe p)
        {
            Ime = p.Ime;
            Prezime = p.Prezime;
            Pozicija = p.Pozicija;
            Telefon = p.Telefon;
            Email = p.Email;
        }

    }
}
