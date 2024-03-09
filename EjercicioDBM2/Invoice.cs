using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDBM2
{
    public class Invoice : IPay
    {
        private List<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal total = 0; //Se deben recorren todos los productos y tomar su total por medio de un acumulado


            foreach (Product product in _products)
            {
                total += product.ValueToPay();
            }
            return total;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); //instanciar un objeto de C# que se llama StringBuilder, que es una herramienta para construir texto más fácil 

            //sb.Append("======== FACTURA ========");
            //sb.Append(Environment.NewLine);
            //sb.Append(Environment.NewLine);

            decimal total = 0;
            foreach (Product product in _products)
            {
                sb.Append(product.ToString());//No es necesario poner el ToString(), ya que con employee sería suficiente, sin embargo, se pone esta vez por memotécnia. 
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                total += product.ValueToPay();
            }
            
            sb.Append("=================================================");
            sb.Append(Environment.NewLine);
            sb.Append($"\n\tTOTAL...................: {$"{total:C2}",15}");

            return sb.ToString();

        }


    }
}
