using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class DzipMap : SubclassMap<Dzip>
    {
        public DzipMap()
        {
            Table("Dzip");
            KeyColumn("Registarska_Oznaka");
        }
    }
}
