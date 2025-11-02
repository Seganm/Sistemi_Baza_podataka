using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    public class SoftveriMap : ClassMap<Softveri>
    {
        public SoftveriMap()
        {
            Table("Softveri");
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
            References(x => x.Analiticar, "JMBG_Analiticara").Cascade.None();
            Map(x => x.Naziv, "Naziv");
        }
    }
}
