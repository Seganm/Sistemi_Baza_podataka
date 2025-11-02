using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    
        public class DTOVanrednaDodajj
        {
            public virtual DateTime DatumPoc { get; set; }
            public virtual DateTime? DatumKraj { get; set; }

            public virtual string Tip { get; set; }
            public virtual int? BrojUgrozenih { get; set; }
            public virtual NivoOpasnosti NivoOpasnost { get; set; }
            public virtual string Opstina { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string? Opis { get; set; } = "";

            public virtual int IdPrijave { get; set; }


            public DTOVanrednaDodajj()
            {

            }

            public DTOVanrednaDodajj(VanrednaSituacija v)
            {
                DatumPoc = v.DatumPoc;
                DatumKraj = v.DatumKraj;
                Tip = v.Tip;
                BrojUgrozenih = v.BrojUgrozenih;
                NivoOpasnost = v.NivoOpasnost;
                Opstina = v.Opstina;
                Lokacija = v.Lokacija;
                Opis = v.Opis;
                IdPrijave = v.PrijavaaID.Id;
            }
        }

        public class DTOPregledVanredneSituacije
        {
            public virtual int Id { get; set; }
            public virtual string Tip { get; set; }
            public virtual string Opstina { get; set; }
            public virtual string Lokacija { get; set; }
            public virtual string NivoOpasnost { get; set; }

            public virtual string? Opis { get; set; }

            public DTOPregledVanredneSituacije() { }
            public DTOPregledVanredneSituacije(VanrednaSituacija v)
            {
                Id = v.Id;
                Tip = v.Tip;
                Opstina = v.Opstina;
                Lokacija = v.Lokacija;
                NivoOpasnost = v.NivoOpasnost.ToString();
                Opis = v.Opis;
            }
        }

        public class DTOVanrednaSituacija
        {
            public virtual int Id { get; set; }
            public virtual DateTime DatumPoc { get; set; }
            public virtual DateTime? DatumKraj { get; set; }

            public virtual string Tip { get; set; }
            public virtual int? BrojUgrozenih { get; set; }
            public virtual string NivoOpasnost { get; set; }
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
                DatumPoc = v.DatumPoc;
                DatumKraj = v.DatumKraj;
                Tip = v.Tip;
                BrojUgrozenih = v.BrojUgrozenih;
                NivoOpasnost = v.NivoOpasnost.ToString();
                Opstina = v.Opstina;
                Lokacija = v.Lokacija;
                Opis = v.Opis;
                Prijava = new DTOPregledPrijave(v.PrijavaaID);
            }
        }

    
}
