using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class EkspertizeMap : ClassMap<Ekspertize>
    {
        public EkspertizeMap()
        {
            Table("Ekspertize");
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
            Map(x => x.Oblast,"Oblast");
            References(x => x.Analiticar, "JMBG").Cascade.None();
        }
    }
}