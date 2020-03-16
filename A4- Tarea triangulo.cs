using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos
            Console.WriteLine("Ingrese c");
            double cGrados = double.Parse(Console.ReadLine());
            double c = cGrados * (Math.PI / 180.0);

            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());

            //Angulo a
            double aGrados = 180 - (cGrados + 90);
            Console.WriteLine("El angulo a es: " + aGrados);

            //hipotenusa

            double h = (z / Math.Sin(c));
            Console.WriteLine("La hipotenusa a es: " + h);

            //El otro cateto

            double y = Math.Sqrt((Math.Pow(h, 2)) - (Math.Pow(z, 2)));
            Console.WriteLine("El otro cateto es: " + y);




        }
    }
}
