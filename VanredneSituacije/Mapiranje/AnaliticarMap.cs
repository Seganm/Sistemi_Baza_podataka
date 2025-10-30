using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class AnaliticarMap : SubclassMap<Analiticar>
    {
        public AnaliticarMap()
        {
            Table("Analiticar");

            KeyColumn("JMBG");
            HasMany(x => x.Softveri)
      .Cascade.All()
      .Inverse()
      .KeyColumn("JMBG_Analiticara");
            HasMany(x => x.Ekspertiza)
          .Cascade.All()
          .Inverse()
          .KeyColumn("JMBG");

       
        }
    }
}
