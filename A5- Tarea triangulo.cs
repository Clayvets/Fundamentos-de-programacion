using System;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese angulo b");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());

            //De angulos a radianes
            double b = bGrados * (Math.PI / 180.0);

            //Hallar angulo a
            double aGrados = (Math.Atan(y / z) * (180.0 / Math.PI));
            
            double a = aGrados * (Math.PI / 180.0);

            //Salida
            double x = ((Math.Tan(a + b)) * z) - y;
            Console.WriteLine("El Valor de X es: " + x);
            
            








        }
    }
}
