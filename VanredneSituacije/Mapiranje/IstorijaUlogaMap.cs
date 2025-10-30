using FluentNHibernate.Mapping;
using NHibernate.Cfg.XmlHbmBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class IstorijaUlogaMap : ClassMap<IstorijaUloga>
    {
        public IstorijaUlogaMap()
        {
            Table("IstorijaUloga");
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
            References(x => x.Zaposleni, "JMBG").Not.Nullable().Cascade.None();
            Map(x => x.Datum_Od).Column("Datum_Od").Not.Nullable();
            Map(x => x.Datum_Do).Column("Datum_Do").Nullable();
            Map(x => x.Uloga).Column("Uloga");
         
        }
    }
}
