using System;

namespace Bubble_Sort {
    class Program {
        static void Main(string[] args) {
            int[] arreglo = { 2, 6, 8, 1, 0, 5, 7, 1 };
            int temporal;
            for (int j = 0; j <= arreglo.Length; j++) {
                for (int i = 0; i < arreglo.Length; i++) {
                    if (arreglo[i] > arreglo[i + 1]) {
                        temporal = arreglo[i + 1];
                        arreglo[i + 1] = arreglo[i];
                        arreglo[i] = temporal;
                    }
                }
            }
            Console.WriteLine("Sorted: ");
            
        }
    }
}
