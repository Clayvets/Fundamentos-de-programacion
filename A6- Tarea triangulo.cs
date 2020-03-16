using System;

namespace Tarea_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese angulo d");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese angulo b");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y");
            double y = double.Parse(Console.ReadLine());

            //De angulo a radianes
            double d = dGrados * (Math.PI / 180.0);
            double b = bGrados * (Math.PI / 180.0);

            double aGrados = (90 - dGrados - bGrados);

            double a = aGrados * (Math.PI / 180.0);

            //Salida
            double z = (y / Math.Tan(a));
            Console.Write("El Valor de Z es: " + z);
          
            


            

           

        }
    }
}
