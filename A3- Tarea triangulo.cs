using System;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos
            Console.WriteLine("Ingrese a: ");
            double aGrados = double.Parse(Console.ReadLine());
            double a = aGrados * (Math.PI / 180.0);

            Console.WriteLine("Ingrese t: ");
            double t = double.Parse(Console.ReadLine());

            //catetos
            double y = (t * Math.Sin(a));
            double z = (t * Math.Cos(a));
            double cGrados = 180 - 90 - aGrados;
            Console.WriteLine("El cateto opuesto y es: " + y);
            Console.WriteLine("El cateto adyacente z es: " + z);
            Console.WriteLine("El angulo c es: " + cGrados);



        }
    }
}
