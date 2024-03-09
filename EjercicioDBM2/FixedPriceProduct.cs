using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDBM2
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price * (1 + (decimal)Tax);
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"\n\tValue...................: {$"{ValueToPay():C2}",15}";
        }
    }
}
