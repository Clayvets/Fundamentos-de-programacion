using System;

namespace Swich_Case {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tipo de contrato (1= Dependiente o 2= Independiente): ");
            int contrato = int.Parse(Console.ReadLine());
            
            double baseCotizacion = 0.4 * salario;
            int ssmlv = 877843, prima = 0;
            double arl = 0, eps = 0, pension = 0;
            double salarioReal = 0, salarioAnual = 0;

            if (baseCotizacion < ssmlv) baseCotizacion = ssmlv;

            switch (contrato) {
                case 1:
                    eps = 0.04 * baseCotizacion;
                    pension = 0.04 * baseCotizacion;
                    prima = salario;
                    salarioReal = salario - (eps + pension + arl * baseCotizacion);
                    salarioAnual = salarioReal * 12 + prima;
                    Console.WriteLine("Salario Real: " + salarioReal);
                    Console.WriteLine("Salario Anual: " + salarioAnual);
                    Console.WriteLine("Salario Eps: " + eps);
                    Console.WriteLine("Salario Pension: " + pension);
                    
                    break;
                case 2:
                    eps = 0.125 * baseCotizacion;
                    pension = 0.16 * baseCotizacion;
                    arl = 0;

                    prima = salario;
                    Console.Write("Ingrese su riesgo (1-5)");
                    int riesgo = int.Parse(Console.ReadLine());
                    switch (riesgo) {

                        case 1: arl = 0.522 / 100; break;
                        case 2: arl = 1.044 / 100; break;
                        case 3: arl = 2.436 / 100; break;
                        case 4: arl = 4.350 / 100; break;
                        case 5: arl = 6.960 / 100; break;
                    }
                    salarioReal = salario - (eps + pension + arl * baseCotizacion);
                    salarioAnual = salarioReal * 12 + prima;
                    Console.WriteLine("Salario Real: " + salarioReal);
                    Console.WriteLine("Salario Anual: " + salarioAnual);
                    Console.WriteLine("Salario Eps: " + eps);
                    Console.WriteLine("Salario Pension: " + pension);

                    break;
                default : Console.WriteLine("Ingreso erroneo"); break;
            }
          
        }
    }
}
