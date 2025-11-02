using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    
        public class DTOPrijava
        {
            public virtual int Id { get; set; }

            public virtual DateTime DatumVremee { get; set; }



            public virtual string Tip { get; set; }
            public virtual string PrijavilacIme { get; set; }
            public virtual string Kontakt { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string Opis { get; set; }
            public virtual string DispecerJMBG { get; set; }

            public virtual int? Prioritet { get; set; }



            public DTOPrijava()
            {
            }

            public DTOPrijava(Prijava p)
            {
                Id = p.Id;
                DatumVremee = p.DatumVremee;
                Tip = p.Tip;
                PrijavilacIme = p.PrijavilacIme;
                Kontakt = p.Kontakt;
                Lokacija = p.Lokacija;
                Opis = p.Opis;
                DispecerJMBG = p.DispecerJMBG;
                Prioritet = p.Prioritet;
            }
        }

        public class DTOPrijavaDodajj
        {

            public virtual DateTime DatumVremee { get; set; }

            public virtual string Tip { get; set; }
            public virtual string PrijavilacIme { get; set; }
            public virtual string Kontakt { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string Opis { get; set; }
            public virtual string DispecerJMBG { get; set; }

            public virtual int? Prioritet { get; set; }


            public DTOPrijavaDodajj()
            {
            }

            public DTOPrijavaDodajj(Prijava p)
            {

                DatumVremee = p.DatumVremee;
                Tip = p.Tip;
                PrijavilacIme = p.PrijavilacIme;
                Kontakt = p.Kontakt;
                Lokacija = p.Lokacija;
                Opis = p.Opis;
                DispecerJMBG = p.DispecerJMBG;
                Prioritet = p.Prioritet;

            }
        }

        public class DTOPregledPrijave
        {
            public virtual int Id { get; set; }
            public virtual DateTime DatumVremee { get; set; }
            public virtual string Tip { get; set; }
            public virtual string PrijavilacIme { get; set; }
            public virtual string Kontakt { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual int? Prioritet { get; set; }

            public virtual string Opis { get; set; }
            public DTOPregledPrijave() { }
            public DTOPregledPrijave(Prijava p)
            {
                Id = p.Id;
                DatumVremee = p.DatumVremee;
                Tip = p.Tip;
                PrijavilacIme = p.PrijavilacIme;
                Kontakt = p.Kontakt;
                Lokacija = p.Lokacija;
                Prioritet = p.Prioritet;
                Opis = p.Opis;
            }
        }


}
