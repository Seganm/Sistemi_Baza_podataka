using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    public class SaradnjaMap : ClassMap<Saradnja>
    {
        public SaradnjaMap()
        {
            Table("Saradnja");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
            References(x => x.Vanredna_Sit)
              .Column("Id_Vanredne_Situacije")
              .Not.Nullable().Cascade.None();
            References(x => x.Sektor)
                .Column("Id_Sluzbe")
                .Not.Nullable().Cascade.None();
            Map(x => x.Uloga).Column("Uloga");
        }
    }
}
