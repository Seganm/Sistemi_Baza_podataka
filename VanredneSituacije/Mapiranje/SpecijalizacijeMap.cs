using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
   
        class SpecijalizacijeMap:ClassMap<Specijalizacije>
        {
            public SpecijalizacijeMap()
            {
                Table("Specijalizacije");
                Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
                Map(x => x.Tip, "Oblast");
                References(x => x.Kordinator, "JMBG_Kordinatora").Cascade.None();
            }
    }
}
