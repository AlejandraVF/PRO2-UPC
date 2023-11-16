namespace Examen
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ClaseArray A = new ClaseArray(5);
            A.ArrayEnteros[0] = 5;
            A.ArrayEnteros[1] = 13;
            A.ArrayEnteros[2] = 37;
            A.ArrayEnteros[3] = 1;
            A.ArrayEnteros[4] = 9;

            A.SumaArrayEnteros();

        }
    }
}
