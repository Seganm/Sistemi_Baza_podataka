using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class SertifikatiMap : ClassMap<Sertifikati>
    {
        public SertifikatiMap()
        {

            Table("Sertifikati");

            CompositeId(x => x.Id)
             .KeyReference(x => x.OperativniRadnik, "JMBG")
             .KeyProperty(x => x.Institucija, "Institucija")
             .KeyProperty(x => x.Naziv, "Naziv");
             
            Map(x => x.DatVazenje).Column("Datum_Vazenja");
            Map(x => x.DatIzdavanje).Column("Datum_Izdavanja");
            


        }
    }
}
