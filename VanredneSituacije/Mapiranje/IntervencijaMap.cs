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
    public class IntervencijaMap : ClassMap<Intervencija>
    {

        public IntervencijaMap()
        {

            Table("Intervencija");


            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity();
            Map(x => x.BrPovredjenih, "Broj_Povredjenih");
            Map(x => x.Uspesnost, "Uspesnost");

            Map(x => x.DatumVremee, "Datum_I_Vreme");
            Map(x => x.Lokacija, "Lokacija");
            
          
            Map(x => x.Status, "Status").CustomType<EnumStringType<Status>>();
            Map(x => x.Resursi, "Resursi");
            Map(x => x.BrSpasenih, "Broj_Spasenih");

            HasMany(x => x.Ucestvovalos)
              .KeyColumn("IdIntervencije")
              .Inverse()
              .Cascade.All();
            HasMany(x => x.Ucestvuje)
                .KeyColumn("IdIntervencije")
                .Inverse()
                .Cascade.All();

          
        }
    }
}
