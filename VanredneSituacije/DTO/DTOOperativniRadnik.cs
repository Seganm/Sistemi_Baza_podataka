using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOOperativniRadnik : DTOZaposleni
    {
        public DTOOperativniRadnik()
        {
        }

        public DTOOperativniRadnik(OperativniRadnik opr) : base(opr)
        {
            Broj_Sati = opr.Broj_Sati;
            Fizicka_Spremnost = opr.Fizicka_Spremnost;
            if (opr.InterventnaJedinica != null)
            {
                InterventnaJedinica = new DTOVratiInterventnuJedinicu(opr.InterventnaJedinica);
            }
        }
        public virtual DTOVratiInterventnuJedinicu? InterventnaJedinica { get; set; }
        public virtual Spremnost Fizicka_Spremnost { get; set; }
        public virtual int Broj_Sati { get; set; }

    }
    public class DTODodajOperativnogRadnika : DTOZaposleni
    {

        public DTODodajOperativnogRadnika()
        {
        }

        public DTODodajOperativnogRadnika(OperativniRadnik opr) : base(opr)
        {

            if (opr.InterventnaJedinica != null)
            {
                InterventnaJedinica = opr.InterventnaJedinica.Jedinstveni_Broj;
            }
            Broj_Sati = opr.Broj_Sati;
            Fizicka_Spremnost = opr.Fizicka_Spremnost;
        }
        public virtual Spremnost Fizicka_Spremnost { get; set; }
        public virtual int Broj_Sati { get; set; }
        public virtual int? InterventnaJedinica { get; set; }


    }
    public class DTOIzmeniOperativnogRadnika : DTOIzmeniZaposlenog
    {
        public DTOIzmeniOperativnogRadnika()
        {

        }

        public DTOIzmeniOperativnogRadnika(OperativniRadnik opr) : base(opr)
        {

            if (opr.InterventnaJedinica != null)
            {
                this.IdJedinice = opr.InterventnaJedinica.Jedinstveni_Broj;
            }
            this.Fizicka_Spremnost = opr.Fizicka_Spremnost;
            this.Broj_Sati = opr.Broj_Sati;
        }


        public virtual int Broj_Sati { get; set; }

        public virtual Spremnost Fizicka_Spremnost { get; set; }


        public virtual int? IdJedinice { get; set; }
     
        }
    }



