using System;

namespace Tarea_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese angulo d");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese x");
            double x = double.Parse(Console.ReadLine());

            //De angulo a radianes
            double d = dGrados * (Math.PI / 180.0);

            //Calculo un lado
            double z = (Math.Sin(d) * w);

            //Salida
            double y = ((z / Math.Tan(d)) - x);
            Console.Write("El Lado Y es: " + y);
        }
    }
}
