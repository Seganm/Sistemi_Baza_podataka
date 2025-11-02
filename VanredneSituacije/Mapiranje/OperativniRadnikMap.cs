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
    class OperativniRadnikMap : SubclassMap<OperativniRadnik>
    {
        public OperativniRadnikMap()
        {
            Table("OPERATIVNIRADNIK");
            KeyColumn("JMBG");
            Map(x => x.FizSpremnost).Column("Fizicka_Spremnost").CustomType<EnumStringType<Spremnost>>(); 
            Map(x => x.BrSati).Column("Broj_Sati");
            References(x => x.InterventnaJedinica).Column("Jedinica_Id").Nullable().LazyLoad();

            HasMany(x => x.Dodeljuje)
                .Cascade.All()
                .Inverse()
                .KeyColumn("JMBG_Pojedinca");

            HasMany(x => x.Sertifikatii)
          .Cascade.All()
          .Inverse()
          .KeyColumn("JMBG");
        }
    }
}