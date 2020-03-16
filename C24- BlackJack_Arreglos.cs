using System;

namespace BlackJack_Arreglos {
    class Program {
        static void Main(string[] args) {
            Random aleatorio = new Random();
            
            int puntaje = 0;
            int carta1 = 0, carta2 = 0, jugador = 0, max = 0, segundo = 0;
            string nombreMayor = "";
            string continuar = "s";
            int[] puntajeJugador = new int[5];
            string[] nombre = new string[5];


            //Minimo de jugadores
            Console.Write("Ingrese numero de jugadores (min 2, max 5)\n");
            int n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 5) {
                Console.Write("Error. (min 2, max 5)");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nINICIO DEL JUEGO\n");

            
            while (jugador < n) {
                jugador++;
                Console.WriteLine("Bienvenido jugador : " + jugador);
                Console.WriteLine("Ingrese su nombre ");
                nombre[jugador] = Console.ReadLine();

                puntajeJugador[jugador] = 0; 
                carta1 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta: " + carta1);
                carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta: " + carta2);
                puntajeJugador[jugador] = carta1 + carta2; 
                Console.WriteLine("Total: " + puntajeJugador[jugador]);

                

                Console.WriteLine("Quieres otra carta (s/n) ?"); 
                continuar = Console.ReadLine();

                while (continuar == "s" && puntajeJugador[jugador] < 21) {
                    carta1 = aleatorio.Next(1, 11);
                    puntajeJugador[jugador] += carta1;
                    Console.WriteLine("Total: " + puntajeJugador[jugador]);
                    if (puntajeJugador[jugador] < 21) {
                        Console.WriteLine("Quieres otra carta (s/n) ?");
                        continuar = Console.ReadLine();
                    }
                    if (puntajeJugador[jugador] > max && puntajeJugador[jugador] < 21) {
                        max = puntajeJugador[jugador];
                        nombreMayor = nombre[jugador];
                    }
                    

                }
                

                Console.WriteLine("Gracias por participar\n");
                

            }
            Console.WriteLine("\nFIN DEL JUEGO");
            Console.WriteLine("El mayor puntaje es para: " + nombreMayor);
            
            for (int i = 0; i < jugador; i++) {
                if (max != puntajeJugador[i + 1]) {
                    if (puntajeJugador[jugador] > segundo && puntajeJugador[jugador] < 21) {
                        segundo = puntajeJugador[jugador];
                        nombreMayor = nombre[jugador];
                    }
                }
            }

            Console.WriteLine("El segundo mayor puntaje es para: " + nombreMayor);

            for (int i = 0; i < jugador; i++) {
                Console.WriteLine("El jugador: " + nombre[i + 1] + " tuvo este puntaje: " + puntajeJugador[i + 1]);
            }

        }
    }
}
