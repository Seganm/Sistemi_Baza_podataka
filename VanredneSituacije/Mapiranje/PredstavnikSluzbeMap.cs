using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class PredstavnikSluzbeMap : ClassMap<PredstavnikSluzbe>
    {

        public PredstavnikSluzbeMap()
        {

            Table("PredstavnikSluzbe");


            Id(x => x.JMBG, "JMBG").GeneratedBy.Assigned();



            Map(x => x.Ime).Column("Ime");
            Map(x => x.Prezime).Column("Prezime");
            Map(x => x.Pozicija).Column("Pozicija");
            Map(x => x.Telefon).Column("Telefon");
            Map(x => x.Email).Column("Email");



        }
    }
}
