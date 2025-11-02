using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class SluzbaMap : ClassMap<Sluzba>
    {
        public SluzbaMap()
        {
            Table("Sluzba");

            Id(x => x.SektorrId, "Id_Sektora").GeneratedBy.TriggerIdentity();

            References(x => x.Predstavnik).Column("JMBGPredstavnika").Unique().Cascade.All();

            Map(x => x.TipSektora).Column("Tip");



            HasMany(x => x.VandredneSituacije)
           .Cascade.All()
           .Inverse()
           .KeyColumn("Id_Sluzbe").LazyLoad();

        }
    }
}
