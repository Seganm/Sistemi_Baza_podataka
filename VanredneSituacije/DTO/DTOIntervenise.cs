using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOIntervenise
    {
        public virtual int Id { get; set; }
        public DTOIntervenise()
        {
        }

        public DTOIntervenise(Intervenise i)
        {
            Id = i.Id;
            
            IdIntervencije = new DTOIntervencija(i.IdIntervencije);
            IdInterventneJed = new DTOVratiInterventnuJedinicu(i.IdInterventneJed);
            IdVandredneSituacije = new DTOPregledVanredneSituacije(i.IdVandredneSituacije);
        }
        public virtual DTOPregledVanredneSituacije IdVandredneSituacije { get; set; }

        public virtual DTOIntervencija IdIntervencije { get; set; }

        public virtual DTOVratiInterventnuJedinicu IdInterventneJed { get; set; }


        

    }
    public class DTOVratiIntervenise
    {
        public virtual int IdVanredneSituacije { get; set; }

        public virtual int IdInterventneJed { get; set; }
        public virtual int IdIntervencije { get; set; }



        public DTOVratiIntervenise()
        {
        }
        public virtual int Id { get; set; }
        public DTOVratiIntervenise(Intervenise i)
        {
            if (i.IdVandredneSituacije != null)
                IdVanredneSituacije = i.IdVandredneSituacije.Id;
            if (i.IdIntervencije != null)
                IdIntervencije = i.IdIntervencije.Id;
            if (i.IdInterventneJed != null)
                IdInterventneJed = i.IdInterventneJed.Jedinstveni_Broj;

            this.Id = i.Id;

        }
    }
    public class DTODodajIntervenise
    {
        public DTODodajIntervenise()
        {
        }

        public DTODodajIntervenise(Intervenise i)
        {
            if (i.IdVandredneSituacije != null)
                IdVanredneSituacije = i.IdVandredneSituacije.Id;
            if (i.IdIntervencije != null)
                IdIntervencije = i.IdIntervencije.Id;
            if (i.IdInterventneJed != null)
                IdInterventneJed = i.IdInterventneJed.Jedinstveni_Broj;
          
        }
        public virtual int IdVanredneSituacije { get; set; }
        public virtual int IdIntervencije { get; set; }
        public virtual int IdInterventneJed { get; set; }


       
    }

    
}
