using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOOpstaInterventnaJedinica : DTOInterventnaJedinica
    {
        public DTOOpstaInterventnaJedinica() { }
        public DTOOpstaInterventnaJedinica(InterventnaJedinica ij) : base(ij) { }
    }
    public class DTOVratiOpstuInterventnuJedinicu : DTOVratiInterventnuJedinicu
    {
        public DTOVratiOpstuInterventnuJedinicu() { }
        public DTOVratiOpstuInterventnuJedinicu(InterventnaJedinica ij) : base(ij) { }
    }
    public class DTOOsnovnaOpstaInterventnaJedinica : DTOOsnovnaInterventnaJedinica
    {
        public DTOOsnovnaOpstaInterventnaJedinica() { }
        public DTOOsnovnaOpstaInterventnaJedinica(InterventnaJedinica ij) : base(ij) { }
    }

   
}
