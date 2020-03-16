using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ingrese votos del partido A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese votos del partido B:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos anulados:");
            double anulados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número total de habitantes:");
            double totalHabitantes = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de mayores de edad:");
            double mayorEdad = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número total de votantes:");
            double totalVotantes = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número total de abstencion:");
            double abstencion = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número total de votos en blanco:");
            double blancos = double.Parse(Console.ReadLine());

            bool A = totalVotantes < 0.03 * (a + b);
            bool B = (a + b) > blancos;
            bool C = abstencion < totalVotantes;
            bool D = a > b;

            if ((A || B) && (C)) {
                Console.WriteLine("Votaciones exitosas");
                if (D) {
                    Console.WriteLine("Gano partido a");
                } else {
                    Console.WriteLine("Gano partido b");
                }
            } else {
                Console.WriteLine("Las elecciones deben ser realizadas nuevamente");
            } 
            



            
            


            
        }
    }
}
