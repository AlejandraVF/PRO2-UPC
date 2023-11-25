
namespace Prog2
{
    public class Program
    {
        /*static void Main()
        {
            int N = 12345; 
            SegundoParcial.MostrarDigImparesRecursivo(N);
        } */

        static void Main()
        {
            int[,] matriz = {
            {5, 2, 1, 1, 1},
            {1, 1, 4, 5, 2},
            {2, 2, 3, 2, 3},
            {9, 8, 6, 7, 4},
            {5, 2, 9, 7, 8}
        };

            SegundoParcial.ImprimirResultadosPorColumna(matriz);
        }


    }

}

