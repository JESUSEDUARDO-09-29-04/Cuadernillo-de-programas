using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double descuento, total_sueldo;
            Console.WriteLine("Ingrese su sueldo quincenal ");
            double sueldo = double.Parse(Console.ReadLine());
            descuento = (sueldo * 0.30) * (24);
            total_sueldo = (descuento + sueldo) * (24);
            Console.WriteLine("Su sueldo total de un año es de " +
           total_sueldo);
            Console.WriteLine("Uste abona " + descuento);
        }
    }
}
