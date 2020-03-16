using System;

namespace Votos_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ingrese votos del partido A:");
            double a = double.Parse(Console.ReadLine()); ;
            Console.WriteLine("Ingrese votos del partido B:");
            double b = double.Parse(Console.ReadLine()); ;
            Console.WriteLine("Ingrese el número total de votos en blanco:");
            double blancos = double.Parse(Console.ReadLine()); ;
            Console.WriteLine("Ingrese el número de votos anulados:");
            double anulados = double.Parse(Console.ReadLine()); ;
            Console.WriteLine("Ingrese el número total de habitantes:");
            double totalHabitantes = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje total de mayor de edad (0% - 100%):");
            double porcentajeMayorEdad = double.Parse(Console.ReadLine())/100;
            double mayorEdad = totalHabitantes * porcentajeMayorEdad;
            double totalVotantes = (a + b + anulados + blancos);
            double abstencion = (mayorEdad - totalVotantes);

            bool A = totalVotantes >  totalHabitantes;
            bool B = (a - b) < (0.1 * totalVotantes);
            bool C = totalVotantes < (0.3 * totalHabitantes);
            bool D = a > b;

            if ((A || B) && (C)) {
                Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");
            } else {
                if (D) {
                    Console.WriteLine("Gano partido a");
                } else {
                    Console.WriteLine("Gano partido b");
                }  
            }
        }
    }
}
