using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2.Mayor_menor_prom09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tres números: ");

            Console.Write("Ingrese primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese tercer número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double mayor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }
           
            if (num3 > mayor)
            {
                mayor = num3;
            }

            Console.WriteLine("El mayor número es: " + mayor);
            Console.ReadKey();  

        }
    }
}
