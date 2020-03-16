using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        double desviacion = 0;
        double total = 0, promedio = 0, cuadrado = 0, totald = 0, resta = 0, suma = 0;

        for (int i = 0; i < notas.Length; i++) {
            total += notas[i];
        }
        promedio = total / notas.Length;

        total = 0;
        //DESVIACION

        for (int j = 0; j < notas.Length; j++) {
            cuadrado = Math.Pow((notas[j] - promedio), 2);
            totald += cuadrado;
        }
        desviacion = Math.Sqrt(totald / notas.Length);
        resta = promedio - desviacion;
        suma = promedio + desviacion;




        for (int i = 0; i < notas.Length; i++) {
            if (resta < notas[i] && suma > notas[i]) {
                salida++;
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double desviacion = 0;
        double total = 0, promedio = 0, cuadrado = 0, totald = 0, resta = 0, suma = 0;

        for (int i = 0; i < notas.Length; i++) {
            total += notas[i];
        }
        promedio = total / notas.Length;

        total = 0;
        //DESVIACION

        for (int j = 0; j < notas.Length; j++) {
            cuadrado = Math.Pow((notas[j] - promedio), 2);
            totald += cuadrado;
        }
        desviacion = Math.Sqrt(totald / notas.Length);
       
        suma = promedio + desviacion;
        
        double[] cercano = new double[notas.Length];

        for (int i = 0; i < notas.Length; i++) {
            cercano[i] = Math.Abs(notas[i] - suma);
        }

        for (int j = 0; j < notas.Length; j++) { // ORDENAMIENTO
            for (int i = 0; i < notas.Length - 1; i++) {
                if (cercano[i] > cercano[i + 1]) {

                    double tmp1 = cercano[i];
                    cercano[i] = cercano[i + 1];
                    cercano[i + 1] = tmp1;

                    string tmp2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tmp2;
                }
            }
        }

        for (int i = 0; i < salida.Length; i++) {
            salida[i] = nombres[i];
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }


    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double desviacion = 0;
        double total = 0, promedio = 0, cuadrado = 0, totald = 0, resta = 0, suma = 0;

        for (int i = 0; i < notas.Length; i++) {
            total += notas[i];
        }
        promedio = total / notas.Length;

        total = 0;
        //DESVIACION

        for (int j = 0; j < notas.Length; j++) {
            cuadrado = Math.Pow((notas[j] - promedio), 2);
            totald += cuadrado;
        }
        desviacion = Math.Sqrt(totald / notas.Length);
        resta = promedio - desviacion;
        suma = promedio + desviacion;
        
        for (int i = 0; i < notas.Length; i++) {
            if (resta < notas[i] && suma > notas[i]) {
                salida.Add(nombres[i]);
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }


    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        /*for (int i = 0; i < nombres.Length; i++) {
            for (int j = 0; j < nombres[i].Length; j++) {
                if (nombres[i][j] == 'A' || nombres[i][j] == 'E' || nombres[i][j] == 'I' || nombres[i][j] == 'O' || nombres[i][j] == 'U' && notas[i]>3) {
                    salida.Add(nombres[i]);
                    
                }
            }
        }*/

        for (int i = 0; i < nombres.Length; i++) {
            int contador = 0;
            
            for (int j = 0; j < nombres[i].Length; j++) {

                if (nombres[i][j] == 'A' || nombres[i][j] == 'E' || nombres[i][j] == 'I' || nombres[i][j] == 'O' || nombres[i][j] == 'U') {
                    contador++;
                }

            }

            if (contador >= 3 && notas[i] > 3) { // SE ALMACENAN EN LA SALIDA
                salida.Add(nombres[i]);
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }
}


