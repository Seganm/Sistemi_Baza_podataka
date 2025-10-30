using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class SanitetskoMap : SubclassMap<Sanitetsko>
    {

        public SanitetskoMap()
        {
            Table("Sanitetsko");

            KeyColumn("Registarska_Oznaka");
        }
    }
}
