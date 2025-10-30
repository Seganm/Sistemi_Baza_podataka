using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOZaposleni
    {
        public DTOZaposleni()
        {
        }
        public DTOZaposleni(Zaposleni zap)
        {
            Ime = zap.Ime;
            Prezime = zap.Prezime;
            JMBG = zap.JMBG;
            Datum_Rodjenja = zap.Datum_Rodjenja;
            Datum_Zaposlenja = zap.Datum_Zaposlenja;
            Kontakt_Telefon = zap.Kontakt_Telefon;
            Email = zap.Email;
            AdresaStanovanja = zap.AdresaStanovanja;
            Pol = zap.Pol;

        }
        public virtual string Ime { get; set; }

        public virtual string Prezime { get; set; }

        public string PunoIme => Ime + " " + Prezime;
        public virtual string JMBG { get; set; }

        public virtual string Pol { get; set; }
        public virtual DateTime Datum_Rodjenja { get; set; }


        public virtual DateTime Datum_Zaposlenja { get; set; }

        public virtual string Kontakt_Telefon { get; set; }

        public virtual string Email { get; set; }

        public virtual string AdresaStanovanja { get; set; }

    }

    public class DTOIzmeniZaposlenog
    {


        public DTOIzmeniZaposlenog()
        {
        }
        public virtual string Ime { get; set; }

        public virtual string Prezime { get; set; }
        public virtual string Email { get; set; }

        public virtual string AdresaStanovanja { get; set; }

        public string PunoIme => Ime + " " + Prezime;



        public virtual string Pol { get; set; }

        public virtual string Kontakt_Telefon { get; set; }



        public virtual DateTime Datum_Rodjenja { get; set; }
        public virtual DateTime Datum_Zaposlenja { get; set; }



        public DTOIzmeniZaposlenog(Zaposleni zap)
        {
            Ime = zap.Ime;
            Prezime = zap.Prezime;
            Pol = zap.Pol;
            AdresaStanovanja = zap.AdresaStanovanja;
            Kontakt_Telefon = zap.Kontakt_Telefon;
            Email = zap.Email;
            Datum_Rodjenja = zap.Datum_Rodjenja;
            Datum_Zaposlenja = zap.Datum_Zaposlenja;
        }
    }
}
