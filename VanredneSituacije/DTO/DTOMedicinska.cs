using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOMedicinska: DTOOprema
    {
        public DTOMedicinska()
        {
        }

        public DTOMedicinska(Medicinska med) : base(med)
        {
            Tip = med.Tip.ToString();
        }
        public virtual string Tip { get; set; }

        
    }

    public class DTODodajMedicinsku : DTODodajOpremu
    {
       
        public DTODodajMedicinsku() { }

        public DTODodajMedicinsku(Medicinska med) : base(med)
        {
            Tip = med.Tip;
        }
        public virtual TipMedicinske Tip { get; set; }
    }

    public class DTOPregledMedicinske : DTOPregledOpreme
    {

        public DTOPregledMedicinske() { }

        public DTOPregledMedicinske(Medicinska m) : base(m)
        {
            Tip = m.Tip.ToString();
        }
        public virtual string Tip { get; set; }
    }
    public class DTOIzmeniMedicinsku : DTOIzmeniOpremu
    {
       
        public DTOIzmeniMedicinsku() { }

        public DTOIzmeniMedicinsku(Medicinska med) : base(med)
        {
            Tip = med.Tip;
        }
        public virtual TipMedicinske Tip { get; set; }
    }

    
}
