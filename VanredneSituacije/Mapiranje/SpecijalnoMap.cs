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
    class SpecijalnoMap : SubclassMap<Specijalno>
    {


        SpecijalnoMap()
        {
            Table("Specijalno");

            KeyColumn("Registarska_Oznaka");

            Map(x => x.Namena).Column("Namena").CustomType<EnumStringType<Namena>>();


        }
    }
}
