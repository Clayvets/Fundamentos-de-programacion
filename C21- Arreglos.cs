using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos {
    class Program {
        static void Main(string[] args) {
            double[] cX = { 0, 2, 3, 7 };
            double[] cY = { 0, 1, 5, 7 };
            double maximo = 0;

            
                double p1 = (cY[1] - cY[0]) / (cX[1] - cX[0]);
                double p2 = (cY[2] - cY[0]) / (cX[2] - cX[0]);
                double p3 = (cY[3] - cY[0]) / (cX[3] - cX[0]);
                double p4 = (cY[2] - cY[1]) / (cX[2] - cX[1]);
                double p5 = (cY[3] - cY[1]) / (cX[3] - cX[1]);
                double p6 = (cY[3] - cY[2]) / (cX[3] - cX[2]);

                if (p1 == p2 || p1 == p3 || p1 == p4 || p1 == p5 || p1 == p6) {
                    Console.WriteLine("Son pendientes");
                } else if (p2 == p3 || p2 == p4 || p2 == p5 || p2 == p6) {
                    Console.WriteLine("Son pendientes");
                } else if (p3 == p4 || p3 == p5 || p3 == p6) {
                    Console.WriteLine("Son pendientes");
                } else if (p4 == p5 || p4 == p6 || p5 == p6) {
                    Console.WriteLine("Son pendientes");
                } else { Console.WriteLine("No son pendientes"); }

            double d1 = Math.Sqrt(Math.Pow((cY[1] - cY[0]), 2) + Math.Pow((cX[1] - cX[0]), 2));
            double d2 = Math.Sqrt(Math.Pow((cY[2] - cY[0]), 2) + Math.Pow((cX[2] - cX[0]), 2));
            double d3 = Math.Sqrt(Math.Pow((cY[3] - cY[0]), 2) + Math.Pow((cX[3] - cX[0]), 2));
            double d4 = Math.Sqrt(Math.Pow((cY[2] - cY[1]), 2) + Math.Pow((cX[2] - cX[1]), 2));
            double d5 = Math.Sqrt(Math.Pow((cY[3] - cY[1]), 2) + Math.Pow((cX[3] - cX[1]), 2));
            double d6 = Math.Sqrt(Math.Pow((cY[3] - cY[2]), 2) + Math.Pow((cX[3] - cX[2]), 2));

            if (d1 > maximo) {
                maximo = d1;

            }else if ((d2 > maximo)) {
                maximo = d2;

            }else if ((d3 > maximo)) {
                maximo = d3;

            }else if ((d4 > maximo)) {
                maximo = d4;

            }else if ((d5 > maximo)) {
                maximo = d5;

            }else if ((d6 > maximo)) {
                maximo = d6;

            }
            Console.WriteLine("La maxima distancia es : " + maximo);


            










        }
    }
}
