using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    
        public class DTODodajVanrednuSituaciju
        {
            public virtual DateTime Datum_Od { get; set; }
            public virtual DateTime? Datum_Do { get; set; }

            public virtual string Tip { get; set; }
            public virtual int? Broj_Ugrozenih_Osoba { get; set; }
            public virtual NivoOpasnosti Nivo_Opasnosti { get; set; }
            public virtual string Opstina { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string? Opis { get; set; } = "";

            public virtual int IdPrijave { get; set; }


            public DTODodajVanrednuSituaciju()
            {

            }

            public DTODodajVanrednuSituaciju(VanrednaSituacija v)
            {
                Datum_Od = v.Datum_Od;
                Datum_Do = v.Datum_Do;
                Tip = v.Tip;
                Broj_Ugrozenih_Osoba = v.Broj_Ugrozenih_Osoba;
                Nivo_Opasnosti = v.Nivo_Opasnosti;
                Opstina = v.Opstina;
                Lokacija = v.Lokacija;
                Opis = v.Opis;
                IdPrijave = v.Prijava_ID.Id;
            }
        }

        public class DTOPregledVanredneSituacije
        {
            public virtual int Id { get; set; }
            public virtual string Tip { get; set; }
            public virtual string Opstina { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string Nivo_Opasnosti { get; set; }

            public virtual string? Opis { get; set; }

            public DTOPregledVanredneSituacije() { }
            public DTOPregledVanredneSituacije(VanrednaSituacija v)
            {
                Id = v.Id;
                Tip = v.Tip;
                Opstina = v.Opstina;
                Lokacija = v.Lokacija;
                Nivo_Opasnosti = v.Nivo_Opasnosti.ToString();
                Opis = v.Opis;
            }
        }

        public class DTOVanrednaSituacija
        {
            public virtual int Id { get; set; }
            public virtual DateTime Datum_Od { get; set; }
            public virtual DateTime? Datum_Do { get; set; }

            public virtual string Tip { get; set; }
            public virtual int? Broj_Ugrozenih_Osoba { get; set; }
            public virtual string Nivo_Opasnosti { get; set; }
            public virtual string Opstina { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string? Opis { get; set; }

            //Dodat getter
            public virtual int IdPrijave { get { return Prijava.Id; } }
            public virtual DTOPregledPrijave Prijava { get; set; }

            public DTOVanrednaSituacija()
            {

            }

            public DTOVanrednaSituacija(VanrednaSituacija v)
            {
                Id = v.Id;
                Datum_Od = v.Datum_Od;
                Datum_Do = v.Datum_Do;
                Tip = v.Tip;
                Broj_Ugrozenih_Osoba = v.Broj_Ugrozenih_Osoba;
                Nivo_Opasnosti = v.Nivo_Opasnosti.ToString();
                Opstina = v.Opstina;
                Lokacija = v.Lokacija;
                Opis = v.Opis;
                Prijava = new DTOPregledPrijave(v.Prijava_ID);
            }
        }

    
}
