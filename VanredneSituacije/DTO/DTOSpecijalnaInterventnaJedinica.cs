using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOSpecijalnaInterventnaJedinica : DTOInterventnaJedinica
    {
        public virtual string TipSpecijalneJedinice { get; set; }

        public DTOSpecijalnaInterventnaJedinica() { }
        public DTOSpecijalnaInterventnaJedinica(SpecijalnaInterventnaJedinica sij) : base(sij)
        {
            TipSpecijalneJedinice = sij.TipSpecijalneJedinice;
        }
    }
    public class DTOVratiSpecijalnuInterventnuJedinicu : DTOVratiInterventnuJedinicu
    {

        public virtual string TipSpecijalneJedinice { get; set; }

        public DTOVratiSpecijalnuInterventnuJedinicu()
        {
        }
        public DTOVratiSpecijalnuInterventnuJedinicu(SpecijalnaInterventnaJedinica sij) : base(sij)
        {

            this.TipSpecijalneJedinice = sij.TipSpecijalneJedinice;
        }
    }
    public class DTOOsnovnaSpecijalnaInterventnaJedinica : DTOOsnovnaInterventnaJedinica
    {
        public virtual string TipSpecijalneJedinice { get; set; }

        public DTOOsnovnaSpecijalnaInterventnaJedinica() { }
        public DTOOsnovnaSpecijalnaInterventnaJedinica(SpecijalnaInterventnaJedinica sij) : base(sij)
        {
            TipSpecijalneJedinice = sij.TipSpecijalneJedinice;
        }
    }

   
}
