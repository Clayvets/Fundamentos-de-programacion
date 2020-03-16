using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
    class Program {
        static void Main(string[] args) {
            double n = 100, x = 0;
            double respuesta = 0;
           
            //Sin(x)
            Console.WriteLine("Ingrese x: ");
            x = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                respuesta += ((Math.Pow(-1, i)) / Factorial((2 * i) + 1)) * (Math.Pow(x, ((2 * i) + 1)));
            }
            Console.WriteLine("sin(x): " + respuesta); 

            //X
            /*for (int i = 0; i < n; i++){
                respuesta += (Math.Pow(x, i))/Factorial(i);
            }
            Console.WriteLine("ex: " + respuesta);*/


        }

        static double Factorial(int valor) {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
