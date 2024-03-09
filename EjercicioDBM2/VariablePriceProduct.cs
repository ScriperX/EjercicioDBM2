using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDBM2
{
    public class VariablePriceProduct : Product
    {
        public string Mesasurement { get; set; }

        public decimal Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return (Quantity * Price) * (1 + (decimal)Tax);//1+0.19=1.19
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tMesasurement............: {$"{Mesasurement}",15}" +
                $"\n\tQuantity................: {$"{Quantity:N2}",15}" +
                $"\n\tPrice...................: {$"{Price:C2}",15}" +
                $"\n\tTax.....................: {$"{Tax:P2}",15}" +
                $"\n\tValue...................: {$"{ValueToPay():C2}",15}";
        }
    }
}