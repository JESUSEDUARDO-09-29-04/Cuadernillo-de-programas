using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, pxh, resultado;
            Console.WriteLine("ingresa un numero");
            n = double.Parse(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("El numero es positivo");
            else
                Console.WriteLine("El numero es negativo");
            Console.ReadKey();
        }
    }
}
