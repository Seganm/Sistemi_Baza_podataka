﻿using System;
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

            public virtual DateTime Datum_I_Vreme { get; set; }



            public virtual string Tip { get; set; }
            public virtual string Ime_Prijavioca { get; set; }
            public virtual string Kontakt { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string Opis { get; set; }
            public virtual string JMBG_Dispecer { get; set; }

            public virtual int? Prioritet { get; set; }



            public DTOPrijava()
            {
            }

            public DTOPrijava(Prijava p)
            {
                Id = p.Id;
                Datum_I_Vreme = p.Datum_I_Vreme;
                Tip = p.Tip;
                Ime_Prijavioca = p.Ime_Prijavioca;
                Kontakt = p.Kontakt;
                Lokacija = p.Lokacija;
                Opis = p.Opis;
                JMBG_Dispecer = p.JMBG_Dispecer;
                Prioritet = p.Prioritet;
            }
        }

        public class DTODodajPrijavu
        {

            public virtual DateTime Datum_I_Vreme { get; set; }

            public virtual string Tip { get; set; }
            public virtual string Ime_Prijavioca { get; set; }
            public virtual string Kontakt { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string Opis { get; set; }
            public virtual string JMBG_Dispecer { get; set; }

            public virtual int? Prioritet { get; set; }


            public DTODodajPrijavu()
            {
            }

            public DTODodajPrijavu(Prijava p)
            {

                Datum_I_Vreme = p.Datum_I_Vreme;
                Tip = p.Tip;
                Ime_Prijavioca = p.Ime_Prijavioca;
                Kontakt = p.Kontakt;
                Lokacija = p.Lokacija;
                Opis = p.Opis;
                JMBG_Dispecer = p.JMBG_Dispecer;
                Prioritet = p.Prioritet;

            }
        }

        public class DTOPregledPrijave
        {
            public virtual int Id { get; set; }
            public virtual DateTime Datum_I_Vreme { get; set; }
            public virtual string Tip { get; set; }
            public virtual string Ime_Prijavioca { get; set; }
            public virtual string Kontakt { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual int? Prioritet { get; set; }

            public virtual string Opis { get; set; }
            public DTOPregledPrijave() { }
            public DTOPregledPrijave(Prijava p)
            {
                Id = p.Id;
                Datum_I_Vreme = p.Datum_I_Vreme;
                Tip = p.Tip;
                Ime_Prijavioca = p.Ime_Prijavioca;
                Kontakt = p.Kontakt;
                Lokacija = p.Lokacija;
                Prioritet = p.Prioritet;
                Opis = p.Opis;
            }
        }


}
