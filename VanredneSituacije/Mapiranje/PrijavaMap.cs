using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class PrijavaMapiranja : ClassMap<Prijava>
    {
        public PrijavaMapiranja()
        {

            Table("Prijava");


            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();



            Map(x => x.DatumVremee, "Datum_I_Vreme");
            Map(x => x.Tip).Column("Tip");
            Map(x => x.PrijavilacIme).Column("Ime_Prijavioca");
            Map(x => x.Kontakt).Column("Kontakt_Prijavioca");
            Map(x => x.Lokacija).Column("Lokacija");
            Map(x => x.Opis).Column("Opis");
            Map(x => x.DispecerJMBG).Column("JMBG_Dispecera");
            Map(x => x.Prioritet).Column("Prioritet");




        }
    }
}
