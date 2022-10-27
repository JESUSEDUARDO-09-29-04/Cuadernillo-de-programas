using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            String fecha = hoy.ToString("dd/MM/yyyy");
            Console.WriteLine(fecha);
            Console.WriteLine("la fecha es correcta?");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
                Console.WriteLine("La bios funciona");
            else if (num == 0)
                Console.WriteLine("La bios no funciona");
            else
                Console.WriteLine("ingrese entre 1 y 0");
        }
    }
}
