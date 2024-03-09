using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDBM2
{
    public class CompoundProducts : Product
    {
        public double Discount { get; set; }

        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal total = 0; //Se deben recorren todos los productos y tomar su total por medio de un acumulado


            foreach (Product product in Products)
            {
                total += product.ValueToPay();
            }
            return total * (1 - (decimal)Discount); 
            // Aplicar cualquier descuento multiplicando el total acumulado por (1 - Descuento) 
            // es decir, (1 - 0.12 = 0.88). Solo se cobrará el 88% del valor total a pagar. 
        }

        public override string ToString()
        {
            //string productDescriptions = string.Join("," , Products.Select(p => p.ToString()));
            //return base.ToString() +
            //    $"\n\tProducts...................: {productDescriptions}";

            string descriptions = string.Join(", ", Products.Select(item => item.Description));
            return $"{Id} - {Description}" +
                $"\n\tProducts................: {descriptions}" +
                $"\n\tDiscount................: {$"{Discount:P2}",15}" +
                $"\n\tValue...................: {$"{(decimal)ValueToPay():C2}",15}";

        }
    }
}

//Estoy teniendo problemas para imprimir la lista de productos, calcular el valor total... 
