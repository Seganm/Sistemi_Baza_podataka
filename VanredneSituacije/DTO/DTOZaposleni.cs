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
            DatumRodj = zap.DatumRodj;
            DatumZap = zap.DatumZap;
            BrojTelefona = zap.BrojTelefona;
            Email = zap.Email;
            AdresaStan = zap.AdresaStan;
            Pol = zap.Pol;

        }
        public virtual string Ime { get; set; }

        public virtual string Prezime { get; set; }

        public string PunoIme => Ime + " " + Prezime;
        public virtual string JMBG { get; set; }

        public virtual string Pol { get; set; }
        public virtual DateTime DatumRodj { get; set; }


        public virtual DateTime DatumZap { get; set; }

        public virtual string BrojTelefona { get; set; }

        public virtual string Email { get; set; }

        public virtual string AdresaStan { get; set; }

    }

    public class DTOIzmeniZaposlenog
    {


        public DTOIzmeniZaposlenog()
        {
        }
        public virtual string Ime { get; set; }

        public virtual string Prezime { get; set; }
        public virtual string Email { get; set; }

        public virtual string AdresaStan { get; set; }

        public string PunoIme => Ime + " " + Prezime;



        public virtual string Pol { get; set; }

        public virtual string BrojTelefona { get; set; }



        public virtual DateTime DatumRodj { get; set; }
        public virtual DateTime DatumZap { get; set; }



        public DTOIzmeniZaposlenog(Zaposleni zap)
        {
            Ime = zap.Ime;
            Prezime = zap.Prezime;
            Pol = zap.Pol;
            AdresaStan = zap.AdresaStan;
            BrojTelefona = zap.BrojTelefona;
            Email = zap.Email;
            DatumRodj = zap.DatumRodj;
            DatumZap = zap.DatumZap;
        }
    }
}
