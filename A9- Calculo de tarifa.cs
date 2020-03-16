using System;

namespace Calculo_de_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());

            double x = 877.803 ;

            if (salario < (x * 2)) {
                Console.WriteLine("Perteneces a la tarifa A");
            } else if ((x * 2) <= salario && salario <= (x * 4)) {
                Console.WriteLine("Perteneces a la tarifa B");
            } else {
                Console.WriteLine("Perteneces a la tarifa C");
            }
            
        }
    }
}
