using System;

namespace Dadox2 {
    class Program {
        static void Main(string[] args) {
            Random aleatorio = new Random();
            int dado = 0, dado2=0, dado1 = 0, total = 0, vida = 3;
            double turnos = 1;
            string continuar = "s";
            
            while (continuar == "s" && total < 100 && vida <= 3) {

                Console.WriteLine("turno actual" + turnos);
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado);
                total += dado;
                
                if (turnos  % 3 == 0 ) {
                    
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado: " + dado2);
                    total += dado2;
                   
                    if (dado == dado2) {
                        vida++;
                        Console.WriteLine("vida +1");
                    }
                }
                Console.WriteLine("Total: " + total);


                if (turnos % 2 == 0) {
                    vida--;
                    Console.WriteLine("Perdiste una vida");
                }

                if (vida == 0) {
                    Console.WriteLine("Se te acabaron las vidas");
                    continuar = "n";
                }

                if (total >= 100) {
                    Console.WriteLine("Ganaste");
                    continuar = "n";
                } else if (total < 100) {
                    Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
                    continuar = Console.ReadLine();
                }

                

                turnos++;
                Console.WriteLine("Vidas" + vida);

            }
            
            Console.WriteLine("Gracias por participar");
        }
    }
}
