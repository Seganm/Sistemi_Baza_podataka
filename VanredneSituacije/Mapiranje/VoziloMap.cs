
using FluentNHibernate.Mapping;
using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class VoziloMap : ClassMap<Vozilo>
    {
        public VoziloMap()
        {
            Table("Vozilo");

            Id(x => x.Registarska_Oznaka, "Registarska_Oznaka").GeneratedBy.Assigned();
            Map(x => x.Status).Column("Status").CustomType<EnumStringType<StatusVozila>>();
            Map(x => x.Lokacija).Column("Lokacija");
            Map(x => x.Proizvodjac).Column("Proizvodjac");

            HasMany(x => x.Dodeljuje)
                .Cascade.All()
                .Inverse()
                .KeyColumn("Registarska_Oznaka");

            HasMany(x => x.Servisi)
           .Cascade.All()
           .Inverse()
           .KeyColumn("Registarska_Oznaka_Vozila");
        }
    }
    class TerenskoMap : SubclassMap<Terensko>
    {

        public TerenskoMap()
        {
            Table("Terensko");

            KeyColumn("Registarska_Oznaka");
        }
    }
}
