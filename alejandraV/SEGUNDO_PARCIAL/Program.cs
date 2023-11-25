
namespace Prog2
{
    public class Program
    {
        /*public static void Main(string[] args)

        {
            int[,] matriz = SegundoParcial.GenerarMatrizSerie();

            Console.WriteLine("Matriz generada:");
            SegundoParcial.MostrarMatriz(matriz);
        }*/
        /*static void Main()
        {
            int N = 12345; // Puedes cambiar el valor de N según tus necesidades
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

