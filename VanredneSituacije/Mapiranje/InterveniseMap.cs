using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class InterveniseMap : ClassMap<Intervenise>
    {
        public InterveniseMap()
        {
            Table("Intervenise");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
            References(x => x.IdVanrednee, "IdVanredneSituacije").Cascade.None();
            References(x => x.IdInterventnee, "IdInterventneJed").Cascade.None();
            References(x => x.IdIntervencijee, "IdIntervencije").Cascade.None();
        }
    }
}
