using System;//Librerias
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Ingrese x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double m = (y2 - y1) / (x2 - x1);
        Console.WriteLine("Pendiente: " + m);

        double b = y1 - m * x1;
        Console.WriteLine("Intercepto: " + b);

       
        double distancia = Math.Sqrt( (Math.Pow(y2 - y1, 2)) + (Math.Pow(x2 - x1, 2)) );
        Console.WriteLine("Distancia: " + distancia);

    }
    }

