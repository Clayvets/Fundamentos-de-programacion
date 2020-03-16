using System;



namespace BlackJack_Multiplayer {
    class Program {
        static void Main(string[] args) {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, total = 0, jugador = 1, max = 0;
            string nombreMenor = "", nombreMayor = "", nombre = "";
            string continuar = "s";
            string reiniciar = "s";


            Console.Write("Ingrese numero de jugadores (min 2, max 5)\n");
            int n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 5) {
                Console.Write("Error. (min 2, max 5)");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nINICIO DEL JUEGO\n");


            while (jugador <= n) {


                Console.WriteLine("Bienvenido jugador : " + jugador);
                Console.WriteLine("Ingrese su nombre ");
                nombre = Console.ReadLine();


                total = 0;
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
                if (total > max && total < 21) {
                    max = total;
                    nombreMayor = nombre;
                }


                Console.WriteLine("Gracias por participar\n");
                jugador += 1;

            }
            Console.WriteLine("\nFIN DEL JUEGO");
            Console.WriteLine("El mayor puntaje es para: " + nombreMayor);
        }
    }
}
