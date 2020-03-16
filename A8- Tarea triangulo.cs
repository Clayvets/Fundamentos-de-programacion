using System;

namespace Tarea_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese angulo c");
            double cGrados = double.Parse(Console.ReadLine());

            //De angulos a radianes
            double c = cGrados * (Math.PI / 180.0);

            double aGrados = (90 - cGrados);
            double a = aGrados * (Math.PI / 180.0);

            //Buscando z
            double z = (Math.Cos(a) * t);
          
            //Buscando y
            double y = (Math.Sin(a) * t);
            
            //Buscando abGrados
            double abGrados = (Math.Acos(z / w));
            
            //Salida
            double x = (Math.Sin(abGrados) * w) - y;
            Console.Write("El Lado x es: " + x);
            
        }
    }
}
