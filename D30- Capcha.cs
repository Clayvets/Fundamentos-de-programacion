using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capcha {
    class Program {
        static void Main(string[] args) {
            int a = 0, b = 0, suma = 0, intentos=1;
            string continuar = "s";
            Random aleatorio = new Random();
            

            while (intentos <= 3 && continuar == "s" ) {
                
                a = aleatorio.Next(1, 11);
                Console.WriteLine("a:" + a);
                b = aleatorio.Next(1, 11);
                Console.WriteLine("b:" + b);
                Console.WriteLine("Escriba la suma de a y b:");
                suma = int.Parse(Console.ReadLine());

                if (intentos == 3) {
                    Console.WriteLine("No tiene mas intentos");
                    continuar = "n";
                }
                if (suma != (a + b)) {
                    Console.WriteLine("Vuelva a intentarlo");
                    continuar = "s";
                    
                } else {
                    Console.WriteLine("Suma correcta");
                    continuar = "n";
                } 
                
                intentos++;
                
            }
           
        }
    }
}
