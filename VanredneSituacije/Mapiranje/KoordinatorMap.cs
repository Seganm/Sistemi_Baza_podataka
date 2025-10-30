﻿using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
     class KoordinatorMap : SubclassMap<Koordinator>
    {
        public KoordinatorMap()
        {
            Table("Koordinator");

            KeyColumn("JMBG");

            Map(x => x.BrojTimova).Column("Broj_Timova");
            HasMany(x => x.Specijalizacija)
                .KeyColumn("JMBG_Kordinatora")
                .Inverse()
                .Cascade.All();
        }
    }
}
