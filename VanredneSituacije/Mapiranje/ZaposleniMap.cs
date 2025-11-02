using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class ZaposleniMap : ClassMap<Zaposleni>
    {
        public ZaposleniMap()
        {
            Table("ZAPOSLENI");

            Id(x => x.JMBG, "JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("Ime");
            Map(x => x.Prezime).Column("Prezime");
            Map(x => x.AdresaStan).Column("Adresa_Stanovanja");
            Map(x => x.DatumRodj).Column("Datum_Rodjenja");
            Map(x => x.BrojTelefona).Column("Kontakt_Telefon");
            Map(x => x.Email).Column("Email");
            Map(x => x.Pol).Column("Pol");
            Map(x => x.DatumZap).Column("Datum_Zaposlenja");
            HasMany(x => x.Istorija)
               .Cascade.All()
               .Inverse()
               .KeyColumn("JMBG");
        }
    }
}
