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
        public virtual string SpecijalnaTip { get; set; }

        public DTOSpecijalnaInterventnaJedinica() { }
        public DTOSpecijalnaInterventnaJedinica(SpecijalnaInterventnaJedinica sij) : base(sij)
        {
            SpecijalnaTip = sij.SpecijalnaTip;
        }
    }
    public class DTOVratiSpecijalnuInterventnuJedinicu : DTOVratiInterventnuJedinicu
    {

        public virtual string SpecijalnaTip { get; set; }

        public DTOVratiSpecijalnuInterventnuJedinicu()
        {
        }
        public DTOVratiSpecijalnuInterventnuJedinicu(SpecijalnaInterventnaJedinica sij) : base(sij)
        {

            this.SpecijalnaTip = sij.SpecijalnaTip;
        }
    }
    public class DTOOsnovnaSpecijalnaInterventnaJedinica : DTOOsnovnaInterventnaJedinica
    {
        public virtual string SpecijalnaTip { get; set; }

        public DTOOsnovnaSpecijalnaInterventnaJedinica() { }
        public DTOOsnovnaSpecijalnaInterventnaJedinica(SpecijalnaInterventnaJedinica sij) : base(sij)
        {
            SpecijalnaTip = sij.SpecijalnaTip;
        }
    }

   
}
