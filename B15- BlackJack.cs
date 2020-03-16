using System;

namespace Black_Jack {
    class Program {
        static void Main(string[] args) {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, total = 0;
            string continuar = "s";
            string reiniciar = "s";

            while (reiniciar == "s") {
                carta1 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta: " + carta1);
                carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta: " + carta2);
                total = carta1 + carta2;
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Quieres otra carta (s/n) ?");
                continuar = Console.ReadLine();

                while (continuar == "s" && total < 21) {

                    carta1 = aleatorio.Next(1, 11);
                    total += carta1;
                    Console.WriteLine("Total: " + total);
                    if (total < 21) {
                        Console.WriteLine("Quieres otra carta (s/n) ?");
                        continuar = Console.ReadLine();
                    }
                }
                Console.WriteLine("Quieres reiniciar (s/n) ?");
                continuar = Console.ReadLine();
            }
        }
    }
}

