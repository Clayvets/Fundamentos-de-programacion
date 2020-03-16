using System;

namespace Dado12Caras {
    class Program {
        static void Main(string[] args) {
            Random aleatorio = new Random();
            int dado = 0, total = 0, dadoAnterior = 0;
            double turnos = 0;
            string continuar = "s";

            dado = aleatorio.Next(10, 13);
            Console.WriteLine("Dado: " + dado);
            total = dado;
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
            continuar = Console.ReadLine();
            turnos++;

            while (continuar == "s" && total < 100) {

                dadoAnterior = dado;
                dado = aleatorio.Next(10, 13);
                Console.WriteLine("Dado: " + dado);
                total += dado;
                Console.WriteLine("Total: " + total);
                turnos++;


                if (dadoAnterior == 12) {


                    if (dado == 10) {
                        Console.WriteLine("Ganaste, 12 y 10 seguidos");
                        continuar = "n";
                    }

                }
                if (continuar != "n") {
                    if (turnos <= 3) {
                        Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
                        continuar = Console.ReadLine();
                    } else if (dado == 1 || dado == 3 || dado == 5 || dado == 7 || dado == 9 || dado == 11) {
                        Console.WriteLine("Perdiste por sacar impar");
                        continuar = "n";
                    } else if (total >= 100) {
                        Console.WriteLine("Ganaste");
                        continuar = "n";
                    } else if (total < 100) {
                        Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
                        continuar = Console.ReadLine();
                    }
                }

            }
            Console.WriteLine("Tiros totales: " + turnos);
            Console.WriteLine("Gracias por participar");

        }
    }
}
