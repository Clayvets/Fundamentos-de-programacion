using System;

namespace Codiguito_de_apoyo {
    class Program {
        static void Main(string[] args) {
            //BUBBLE SORT

            for (int j = 0; j < notas.Length; j++) { // ORDENAMIENTO
                for (int i = 0; i < notas.Length - 1; i++) {
                    if (notas[i] > notas[i + 1]) {

                        double tmp1 = notas[i];
                        notas[i] = notas[i + 1];
                        notas[i + 1] = tmp1;

                        string tmp2 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp2;
                    }
                }
            }
            //PARA LA MEDIANA PRIMERO SE ORDENA
            //MEDIANA

            double mediana = 0;
            if (notas.Length % 2 != 0) { // IMPAR
                mediana = notas[(int)(notas.Length / 2)];
            } else { // PAR
                mediana = (notas[(int)(notas.Length / 2)] + notas[(int)(notas.Length / 2) - 1]) / 2;
            }

            //DISTANCIAS
            //hay que hacer el bubble sort
            double[] distancias = new double[notas.Length];

            for (int i = 0; i < notas.Length; i++) {
                distancias[i] = Math.Abs(notas[i] - promedio);
            }

            //LETRA

            for (int i = 0; i < nombres.Length; i++) { // RECORRER LOS NOMBRES
                int contador = 0;
                for (int j = 0; j < nombres[i].Length; j++) { // RECORRER LAS LETRAS
                    if (nombres[i][j] == 'A') {
                        contador++;
                    }
                } // FIN RECORRER LETRAS

                if (contador == 0 && notas[i] >= 4) { // SE ALMACENAN EN LA SALIDA
                    salida.Add(nombres[i]);
                }




            }
    }
}
