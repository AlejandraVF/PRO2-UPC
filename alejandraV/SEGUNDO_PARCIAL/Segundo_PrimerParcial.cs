
public class SegundoParcial
{
    /*public static int[,] GenerarMatrizSerie()
    {
        int[,] matriz = new int[5, 5];
        int valor = 1;

        for (int col = 0; col < 5; col++)
        {
            for (int fila = 0; fila < 5; fila++)
            {
                matriz[fila, col] = valor++;
                if (valor > 7)
                    valor = 1;
            }
        }

        return matriz;
    }

    public static void MostrarMatriz(int[,] matriz)
    {
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
                Console.Write(matriz[fila, col] + " ");
            }
            Console.WriteLine();
        }
    }
    */

    //Convertir el algoritmo iterativo a su equivalente de manera recursiva

    /*public static void MostrarDigImparesRecursivo(int N)
    {
        MostrarDigitosImpares(N);
    }

    private static void MostrarDigitosImpares(int N)
    {
        if (N != 0)
        {
            int dig = N % 10;
            if (dig % 2 != 0)
            {
                Console.WriteLine("Dig: " + dig);
            }
            MostrarDigitosImpares(N / 10);
        }
    }*/


    public static void ImprimirResultadosPorColumna(int[,] matriz)
    {
        for (int col = 0; col < matriz.GetLength(1); col++)
        {
            int suma = SumarElementosPorColumna(matriz, col);
            Console.WriteLine($"Columna {col + 1}: {suma}");
        }
    }

    private static int SumarElementosPorColumna(int[,] matriz, int col)
    {
        int suma = 0;
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            suma += matriz[fila, col];
        }
        return suma;
    }
}


