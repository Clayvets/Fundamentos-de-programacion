using System;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());

            //Hipotenusa
            double t = Math.Sqrt((Math.Pow(y, 2)) + (Math.Pow(z, 2)));
            Console.WriteLine("Hipotenusa: " + t);

            //Angulos 
            double c = Math.Asin(z / t);
            double a = Math.Asin(y / t);
            double b = 90;

            //De angulos a radianes
            c = c * (180.0 / Math.PI);
            a = a * (180.0 / Math.PI);
            Console.WriteLine("Angulo 1: " + c);
            Console.WriteLine("Angulo 2: " + a);
            Console.WriteLine("Angulo 3: " + b);
        }
    }
}
