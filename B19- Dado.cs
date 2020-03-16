using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado {
    class Program {
        static void Main(string[] args) {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, pares = 0;
            double  contador =0, contadorS= 0, porcentaje= 0;
            string continuar = "s";

            dado1 = aleatorio.Next(1, 7);
            Console.WriteLine("Dado: " + dado1);
            dado2 = aleatorio.Next(1, 7);
            Console.WriteLine("Dado: " + dado2);
            total = dado1 + dado2;
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
            continuar = Console.ReadLine();
            
            

            while (continuar == "s" && total < 100) {

                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado1);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado2);
                total += (dado1 + dado2);
                Console.WriteLine("Total: " + total);
                contador++;
                if (dado1+dado2 > 6) {
                    contadorS++;
                }

                if (dado1 == dado2) {
                    pares++;
                    Console.WriteLine("Pares: " + pares);
                    if (pares == 3) {
                        Console.WriteLine("Ganaste");
                        continuar = "n";
                    } else {
                        Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
                        continuar = Console.ReadLine();
                    }

                } else if (total >= 100) {
                    Console.WriteLine("Ganaste");
                    continuar = "n";
                } else if (total < 100) {
                    Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
                    continuar = Console.ReadLine();
                } else if (dado1==1 && dado2 == 1) {
                    Console.WriteLine("Perdiste por sacar en los dos dados 1");
                    continuar = "n";
                } 
            }

            Console.WriteLine("Su total fue: " +  total +  "puntos");
            Console.WriteLine("Tiros totales: " + contador);
            porcentaje = ((contadorS / contador) * 100);
            Console.WriteLine("Porcentaje: " + porcentaje);
            Console.WriteLine("x: " + contadorS);
            Console.WriteLine("Gracias por participar");
        }
    }
}
