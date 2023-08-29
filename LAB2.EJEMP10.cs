using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.prom10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double MConsumo;
            double descuento = 0;
            double impuesto;
            double subtotal;
            double total;

            Console.Write("Ingrese el monto del consumo: ");
            MConsumo = Convert.ToDouble(Console.ReadLine());

            if (MConsumo <= 100.00)
            {
                descuento = MConsumo * 0.10;
            }
            else
            {
                descuento = MConsumo * 0.20;
            }

            impuesto = MConsumo * 0.18;
            subtotal = MConsumo - descuento;
            total = subtotal + impuesto;

            Console.WriteLine("Monto del descuento: S/ " + descuento.ToString("0.00"));
            Console.WriteLine("Impuesto: S/ " + impuesto.ToString("0.00"));
            Console.WriteLine("Subtotal: S/ " + subtotal.ToString("0.00"));
            Console.WriteLine("Importe a pagar: S/ " +  total.ToString("0.00"));
            Console.ReadKey();  
        }
    }
}
