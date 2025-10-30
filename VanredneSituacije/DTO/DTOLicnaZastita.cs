using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.DTO
{
    public class DTOLicnaZastita : DTOOprema
    {
        public DTOLicnaZastita() { }
        public DTOLicnaZastita(LicnaZastita lz) : base(lz)
        {
            Tip = lz.Tip.ToString();
        }
        public virtual string Tip { get; set; }
       
    }
    public class DTOPregledLicneZastite : DTOPregledOpreme
    {
        public DTOPregledLicneZastite() { }
        public DTOPregledLicneZastite(LicnaZastita lz) : base(lz)
        {
            Tip = lz.Tip.ToString();
        }
        public virtual string Tip { get; set; }
    }
    public class DTODodajLicnuZastitu : DTODodajOpremu
    {
        public DTODodajLicnuZastitu() { }
        public DTODodajLicnuZastitu(LicnaZastita lz) : base(lz)
        {
            Tip = lz.Tip;
        }
        public virtual TipLicneZastite Tip { get; set; }

     
    }

    public class DTOIzmeniLicnuZastitu : DTOIzmeniOpremu
    {
        public DTOIzmeniLicnuZastitu() { }
        public DTOIzmeniLicnuZastitu(LicnaZastita lz) : base(lz)
        {
            Tip = lz.Tip;
        }
        public virtual TipLicneZastite Tip { get; set; }
       
    }

    
}
