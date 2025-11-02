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
            BrSati = opr.BrSati;
            FizSpremnost = opr.FizSpremnost;
            if (opr.InterventnaJedinica != null)
            {
                InterventnaJedinica = new DTOVratiInterventnuJedinicu(opr.InterventnaJedinica);
            }
        }
        public virtual DTOVratiInterventnuJedinicu? InterventnaJedinica { get; set; }
        public virtual Spremnost FizSpremnost { get; set; }
        public virtual int BrSati { get; set; }

    }
    public class DTOOperativniDodajja : DTOZaposleni
    {

        public DTOOperativniDodajja()
        {
        }

        public DTOOperativniDodajja(OperativniRadnik opr) : base(opr)
        {

            if (opr.InterventnaJedinica != null)
            {
                InterventnaJedinica = opr.InterventnaJedinica.JedinstveniBroj;
            }
            BrSati = opr.BrSati;
            FizSpremnost = opr.FizSpremnost;
        }
        public virtual Spremnost FizSpremnost { get; set; }
        public virtual int BrSati { get; set; }
        public virtual int? InterventnaJedinica { get; set; }


    }
    public class DTOOperativniIzmeniiRadnika : DTOIzmeniZaposlenog
    {
        public DTOOperativniIzmeniiRadnika()
        {

        }

        public DTOOperativniIzmeniiRadnika(OperativniRadnik opr) : base(opr)
        {

            if (opr.InterventnaJedinica != null)
            {
                this.IdJedinice = opr.InterventnaJedinica.JedinstveniBroj;
            }
            this.FizSpremnost = opr.FizSpremnost;
            this.BrSati = opr.BrSati;
        }


        public virtual int BrSati { get; set; }

        public virtual Spremnost FizSpremnost { get; set; }


        public virtual int? IdJedinice { get; set; }
     
        }
    }



