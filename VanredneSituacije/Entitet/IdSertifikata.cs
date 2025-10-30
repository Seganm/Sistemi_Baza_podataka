using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanredneSituacije.Entitet
{
    public class IdSertifikata
    {
        public virtual string Institucija { get; set; }
        public virtual string Naziv { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object o)
        {
            IdSertifikata objekat = (IdSertifikata)o;
            if (o.GetType() != typeof(IdSertifikata))
                return false;
            if (ReferenceEquals(this, o))
                return true;

            if (OperativniRadnik.JMBG == objekat.OperativniRadnik.JMBG &&
                 Naziv == objekat.Naziv && Institucija == objekat.Institucija)
            {
                return true;
            }

            return false;
        }
        public virtual OperativniRadnik OperativniRadnik { get; set; }
    }
}
