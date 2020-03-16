using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su altura en m");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su peso en kg");
            double w = double.Parse(Console.ReadLine());

            double a = Math.Pow(h, 2);

            double iMC = (w / a);
            Console.WriteLine("Su ICM es: " + iMC);

            if (iMC <= 15) {
                Console.WriteLine("Tiene delgadez muy severa");
            } else if (15 <= iMC && iMC <= 15.9) {
                Console.WriteLine("Tiene delgadez severa");
            } else if (16 <= iMC && iMC <= 18.4) {
                Console.WriteLine("Tiene delgadez ");
            } else if (18.5 <= iMC && iMC <= 24.9) {
                Console.WriteLine("Tiene peso saludable");
            } else if (25 <= iMC && iMC <= 29.9) {
                Console.WriteLine("Tiene sobrepeso");
            } else if (30 <= iMC && iMC <= 34.9) {
                Console.WriteLine("Tiene obesidad moderada");
            } else if (35 <= iMC && iMC <= 39.9) {
                Console.WriteLine("Tiene obesidad severa");
            } else  {
                Console.WriteLine("Tiene obesidad muy severa");
            }








            }
    }
}
