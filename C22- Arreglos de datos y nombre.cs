using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majojo_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese su numero de datos");
            int n = int.Parse(Console.ReadLine());
            int mayor = 0, menor = 200 ;
            string nombrema = "", nombreme = "" , nombrep = "";
            double promedio = 0, total = 0, desviacion = 0, cuadrado = 0, totald = 0, distancia = 0, cercana = 200;
                        
            int[] edades = new int[n];
            string[] nombres = new string[n];
            
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("ingrese un nombre");
                nombres[i]= Console.ReadLine();
                Console.WriteLine("ingrese una edad");
                edades[i] = int.Parse(Console.ReadLine());

                if (edades[i] < menor)
                {
                    menor = edades[i];
                    nombreme = nombres[i];
                }

                if (edades[i] > mayor)
                {
                    mayor= edades[i];
                    nombrema = nombres[i];
                }
                total += edades[i];
                promedio = total / n;
                
               
            }


            total = 0;
            for (int j = 0; j < edades.Length; j++)
            {
                cuadrado = Math.Pow((edades[j] - promedio), 2);
                totald += cuadrado;


                distancia = Math.Sqrt(Math.Pow((edades[j] - promedio), 2));
                if ( distancia < cercana)
                {
                    cercana = distancia;
                    nombrep = nombres[j];
                }
            }

            desviacion = Math.Sqrt(totald / n);
            Console.WriteLine("nombre y edad del mayor: " + nombrema +" de "+ mayor);
            Console.WriteLine("nombre y edad del menor: " + nombreme + " de " + menor);
            Console.WriteLine("promedio edades: " + promedio);
            Console.WriteLine("desviacion: " + desviacion);
            Console.WriteLine("nombre cercano: " + nombrep);






        }
    }
}
