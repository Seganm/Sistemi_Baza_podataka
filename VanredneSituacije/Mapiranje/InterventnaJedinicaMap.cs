using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranje
{
    class InterventnaJedinicaMap : ClassMap<InterventnaJedinica>
    {
        public InterventnaJedinicaMap()
        {
            Table("InterventnaJedinica");

            Id(x => x.Jedinstveni_Broj, "Jedinstveni_Broj").GeneratedBy.TriggerIdentity();

            References(x => x.Komandir)
            .Column("JMBG_KOMANDIRA")
            .Unique()
            .Cascade.None()
            .LazyLoad();
           

            Map(x => x.Baza, "Baza");

            Map(x => x.Naziv, "Naziv");
            Map(x => x.BrojClanova, "Broj_Clanova");
            HasMany(x => x.Dodeljuje).KeyColumn("IdJedinice").Inverse().Cascade.All().LazyLoad();
            HasMany(x => x.Radnici).KeyColumn("Jedinica_Id").Inverse().Cascade.All().LazyLoad();

            HasMany(x => x.Oprema).KeyColumn("Id_Jedinice").Cascade.All();
            
            HasMany(x => x.Ucestvuje).KeyColumn("IdInterventneJed").Inverse().Cascade.All().LazyLoad();

        }
    }
    class SpecijalnaInterventnaJedinicaMap : SubclassMap<SpecijalnaInterventnaJedinica>
    {
        public SpecijalnaInterventnaJedinicaMap()
        {


            Table("SpecijalnaInterventnaJedinica");
            KeyColumn("Jedinstveni_Broj");
            Map(x => x.TipSpecijalneJedinice, "TipSpecijalneJedinice");
        }
    }
    class OpstaInterventnaJedinicaMap : SubclassMap<OpstaInterventnaJedinica>
    {
        public OpstaInterventnaJedinicaMap()
        {
            Table("OpstaInterventnaJedinica");

            KeyColumn("Jedinstveni_Broj");
        }
    }

    
}
