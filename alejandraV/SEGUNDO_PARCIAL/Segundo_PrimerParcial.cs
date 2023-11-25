
public class SegundoParcial
{

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


