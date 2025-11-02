using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
 
    public class VanrednaSituacija
    {
        public VanrednaSituacija()
        {
            Ucestvuje = new List<Intervenise>();
            Saradjuje = new List<Saradnja>();
        }
        public virtual int Id { get; set; }
        public virtual IList<Intervenise> Ucestvuje { get; set; }
        public virtual IList<Saradnja> Saradjuje { get; set; }
        public virtual string Opstina { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string? Opis { get; set; }
        public virtual string Tip { get; set; }
        public virtual int? BrojUgrozenih { get; set; }
        public virtual NivoOpasnosti NivoOpasnost { get; set; }
        public virtual DateTime DatumPoc { get; set; }
        public virtual DateTime? DatumKraj { get; set; }

        public virtual Prijava PrijavaaID { get; set; }
    }
    public enum NivoOpasnosti
    {
        nizak, srednji, visok
    }
}
