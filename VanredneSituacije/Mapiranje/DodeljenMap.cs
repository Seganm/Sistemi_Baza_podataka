using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    public class DodeljenMap:ClassMap<Dodeljen>
    {
        public DodeljenMap()
        {
            Table("Dodeljen");
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
 
            References(x => x.Vozilo, "Registarska_Oznaka").Not.Nullable().Cascade.None();
            References(x => x.Radnik, "JMBG_Pojedinca").Nullable().Cascade.None();
            References(x => x.Jedinica, "IdJedinice").Nullable().Cascade.None();
            Map(x => x.DatumOd).Column("DatumPoc");
            Map(x => x.DatumDo).Column("DatumKraj");


        }
    }
}
