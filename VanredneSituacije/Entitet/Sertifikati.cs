using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Mapiranje;

namespace VanredneSituacije.Entitet
{
    public class Sertifikati
    {
        public Sertifikati()
        {
            Id = new IdSertifikata();
        }
        public virtual IdSertifikata Id { get; set; }
        public virtual DateTime? DatVazenje { get; set; }
        public virtual DateTime DatIzdavanje { get; set; } 
    }
}
