using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class KamionMap : SubclassMap<Kamion>
    {
        public KamionMap()
        {
            Table("Kamion");
            KeyColumn("Registarska_Oznaka");
        }
    }
}
