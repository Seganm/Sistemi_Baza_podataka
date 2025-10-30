﻿using FluentNHibernate.Mapping;
using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Mapiranja
{
    class VanrednaSituacijaMap : ClassMap<VanrednaSituacija>
    {
        public VanrednaSituacijaMap()
        {
            Table("VanrednaSituacija");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.Datum_Od).Column("Datum_Od");
            Map(x => x.Datum_Do).Column("Datum_Do");
            Map(x => x.Tip).Column("Tip");
            Map(x => x.Broj_Ugrozenih_Osoba).Column("Broj_Ugrozenih_Osoba");
            Map(x => x.Nivo_Opasnosti).Column("Nivo_Opasnosti").CustomType<EnumStringType<NivoOpasnosti>>();
            Map(x => x.Opstina).Column("Opstina");
            Map(x => x.Lokacija).Column("Lokacija");
            Map(x => x.Opis).Column("Opis");


            References(x => x.Prijava_ID).Column("Id_Prijave").Cascade.None();


            HasMany(x => x.Ucestvuje)
           .Cascade.All()
           .Inverse()
           .KeyColumn("IdVanredneSituacije");

            HasMany(x => x.Saradjuje)
                .Cascade.All()
                .Inverse()
                .KeyColumn("Id_Vanredne_Situacije");




        }
    }
}
