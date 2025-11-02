using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    public class AngazovanoMap : ClassMap<Angazovano>
    {
        public AngazovanoMap()
        {
            Table("Angazovano");
            Id(x => x.ID, "Id").GeneratedBy.TriggerIdentity();
            Map(x => x.DatumKraj, "Datum_Do");
            Map(x => x.DatumPoc, "Datum_Od");
            References(x => x.Intervencija)
                .Column("IdIntervencije")
                .Not.Nullable().Cascade.None();
            References(x => x.Vozilo)
                .Column("Registarska_Oznaka_Vozila")
                .Not.Nullable().Cascade.None();
        }
    }
}
