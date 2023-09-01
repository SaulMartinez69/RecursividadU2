using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadU2
{
    internal class Program
    {
        static double Elevar(double baseValue, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return baseValue * Elevar(baseValue, exponent - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            double baseValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            double result = Elevar(baseValue, exponent);
            Console.WriteLine($"El resultado es: {result}");
            Console.ReadKey();
        }
    }
}
