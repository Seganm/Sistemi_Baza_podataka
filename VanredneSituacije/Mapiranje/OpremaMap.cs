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
    class OpremaMap : ClassMap<Oprema>
    {
        public OpremaMap()
        {
            Table("Oprema");


            Id(x => x.Serijski_Broj, "Serijski_Broj").GeneratedBy.Assigned();

            References(x => x.Jedinica, "Id_Jedinice").Cascade.None();
            Map(x => x.Status).Column("Status").CustomType<EnumStringType<StatusOpreme>>();
            Map(x => x.DatumNabavke).Column("DatumNabavke");


            Map(x => x.Naziv).Column("Naziv");


        }
    }

  
    class ZalihaMap : SubclassMap<Zaliha>
    {
        public ZalihaMap()
        {
            Table("Zaliha");

            KeyColumn("Serijski_Broj");
            Map(x => x.Kolicina, "Kolicina");
            Map(x => x.Tip).Column("Tip").CustomType<EnumStringType<TipZalihe>>();
        }
    }
    

    class LicnaZastitaMap : SubclassMap<LicnaZastita>
    {
        public LicnaZastitaMap()
        {
            Table("LicnaZastita");

            KeyColumn("Serijski_Broj");
            Map(x => x.Tip).Column("Tip").CustomType<EnumStringType<TipLicneZastite>>();

        }
    }
    class MedicinskaMap : SubclassMap<Medicinska>
    {
        public MedicinskaMap()
        {
            Table("Medicinska");

            KeyColumn("Serijski_Broj");
            Map(x => x.Tip).Column("Tip").CustomType<EnumStringType<TipMedicinske>>();

        }
    }
    class TehnickaMap : SubclassMap<Tehnicka>
    {
        public TehnickaMap()
        {
            Table("Tehnicka");

            KeyColumn("Serijski_Broj");
            Map(x => x.Tip).Column("Tip").CustomType<EnumStringType<TipTehnicke>>();

        }
    }

}
