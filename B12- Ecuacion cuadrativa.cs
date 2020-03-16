using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuacion_cuadratica {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ingrese a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c");
            double c = double.Parse(Console.ReadLine());

            double discriminante = (Math.Pow(b, 2) - (4 * a * c));

            if (discriminante == 0) {
                double ecuacion1 = (-b) / (2 * a);
                Console.WriteLine("Solucion unica: " + ecuacion1);
            } else if (discriminante > 0) {
                double ecuacion1 = (-b + (Math.Sqrt(discriminante))) / (2 * a);
                double ecuacion2 = (-b - (Math.Sqrt(discriminante))) / (2 * a);
                Console.WriteLine("X1: " + ecuacion1);
                Console.WriteLine("X2: " + ecuacion2);
            } else { 
                Console.WriteLine("No tiene solucion ");
            }

           
        }
    }
}
