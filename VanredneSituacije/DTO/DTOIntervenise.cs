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
            
            IdIntervencijee = new DTOIntervencija(i.IdIntervencijee);
            IdInterventnee = new DTOVratiInterventnuJedinicu(i.IdInterventnee);
            IdVanrednee = new DTOPregledVanredneSituacije(i.IdVanrednee);
        }
        public virtual DTOPregledVanredneSituacije IdVanrednee { get; set; }

        public virtual DTOIntervencija IdIntervencijee { get; set; }

        public virtual DTOVratiInterventnuJedinicu IdInterventnee { get; set; }


        

    }
    public class DTOVratiIntervenise
    {
        public virtual int IdVanredneSituacije { get; set; }

        public virtual int IdInterventnee { get; set; }
        public virtual int IdIntervencijee { get; set; }



        public DTOVratiIntervenise()
        {
        }
        public virtual int Id { get; set; }
        public DTOVratiIntervenise(Intervenise i)
        {
            if (i.IdVanrednee != null)
                IdVanredneSituacije = i.IdVanrednee.Id;
            if (i.IdIntervencijee != null)
                IdIntervencijee = i.IdIntervencijee.Id;
            if (i.IdInterventnee != null)
                IdInterventnee = i.IdInterventnee.JedinstveniBroj;

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
            if (i.IdVanrednee != null)
                IdVanredneSituacije = i.IdVanrednee.Id;
            if (i.IdIntervencijee != null)
                IdIntervencijee = i.IdIntervencijee.Id;
            if (i.IdInterventnee != null)
                IdInterventnee = i.IdInterventnee.JedinstveniBroj;
          
        }
        public virtual int IdVanredneSituacije { get; set; }
        public virtual int IdIntervencijee { get; set; }
        public virtual int IdInterventnee { get; set; }


       
    }

    
}
