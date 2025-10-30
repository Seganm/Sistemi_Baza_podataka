using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class EvidencijaServisMap : ClassMap<EvidencijaServis>
    {
        public EvidencijaServisMap()
        {
            Table("EvidencijaServis");
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
            
            Map(x => x.Datum).Column("Datum");

            Map(x => x.TipServisa).Column("Tip");

            References(x => x.Vozilo, "Registarska_Oznaka_Vozila").Cascade.None();


        }
    }
}