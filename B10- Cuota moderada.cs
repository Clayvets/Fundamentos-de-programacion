using System;

namespace Cuota_moderada {
    class Program {
        static void Main(string[] args) {
            //Datos
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());

            double x = 877.803;
            

            if (salario < (x * 2)) {
                Console.WriteLine("Perteneces a la tarifa A y tu cuota es de: 3400");
            } else if ((x * 2) <= salario && salario <= (x * 4)) {
                Console.WriteLine("Perteneces a la tarifa B y tu cuota es de: 13500");
            } else {
                Console.WriteLine("Perteneces a la tarifa C y tu cuota es de: 35600");
            }
        }
    }
}
