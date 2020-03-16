using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadoVidas {
    class Program {
        static void Main(string[] args) {
            Random aleatorio = new Random();
            int dado = 0, total = 0, vida = 3, contUno = 0, contSeis = 0, dadoEsp=0, contDadoE = 0, dadoAnterior = 0;
            double turnos = 0;
            string continuar = "s";
            string dadoEspecial = "s";
            



            /*dado = aleatorio.Next(1,2);
            Console.WriteLine("Dado: " + dado);
            total = dado;
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
            continuar = Console.ReadLine();
            turnos++;*/

            while (continuar == "s" && total < 100 && vida <= 3) {


                if (contDadoE < 2) {
                    Console.WriteLine("¿Quieres tirar un dado especial? (s/n)");
                    dadoEspecial = Console.ReadLine();
                    if (dadoEspecial == "s") {
                        dadoEsp = aleatorio.Next(1, 13);
                        Console.WriteLine("Dado Especial: " + dadoEsp);
                        total += dadoEsp;
                        Console.WriteLine("Total: " + total);
                        contDadoE++;
                    }
                } else {
                    dadoEspecial = "n";
                }

                if (dadoEspecial != "s") {
                    dadoAnterior = dado;
                    dado = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado: " + dado);
                    total += dado;
                    Console.WriteLine("Total: " + total);
                    turnos++;
                }
                

                
                    


                if (dado == 1) {
                    contUno++;
                    if (contUno % 2 == 0 && total!=0) {
                        vida--;
                        total -= 10;
                        Console.WriteLine("Perdiste 1 vida y 10 puntos");
                    }
                }
                
               if (dadoAnterior == 6 && vida < 3) {

                  if (dado == 6) {
                    vida++;
                    Console.WriteLine("Ganaste 1 vida");

                  }
               }

                

                if (total >= 100) {
                    Console.WriteLine("Ganaste");
                    continuar = "n";
                } else if (total < 100) {
                    Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
                    continuar = Console.ReadLine();
                    
                }



                /*if (dadoAnterior == 12) {


                    if (dado == 10) {
                        Console.WriteLine("Ganaste, 12 y 10 seguidos");
                        continuar = "n";
                    }

                }*/


                /*if (turnos <= 3) {
                    Console.WriteLine("Quieres tirar de nuevo (s/n) ?");
                    continuar = Console.ReadLine();
                }*/



            }
            Console.WriteLine("Tiros totales: " + turnos);
            Console.WriteLine("Gracias por participar");

        }
    }
}
