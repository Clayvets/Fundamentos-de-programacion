using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese b4: ");
            double b4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b3: ");
            double b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b0: ");
            double b0 = double.Parse(Console.ReadLine());

            b4 = b4 * Math.Pow(2, 4);
            b3 = b3 * Math.Pow(2, 3);
            b2 = b2 * Math.Pow(2, 2);
            b1 = b1 * Math.Pow(2, 1);
            b0 = b0 * Math.Pow(2, 0);

            double suma = b4 + b3 + b2 + b1 + b0;
            Console.WriteLine("Su numero es: " + suma);



        }
    }
}
