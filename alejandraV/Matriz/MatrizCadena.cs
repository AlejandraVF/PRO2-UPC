public class MatrizCadena
{
    public string[,] M; //Elemento de la Matriz
    public int fila;//Cantidad de filas
    public int columna;//Cantidad de columnas
    public string defaultValue = "100";//Valor por defecto

    //El constructor vacio
    /*public MatrizCadena()
    {
        M = new string[0, 0];
        fila = 0;
        columna = 0;
    }*/

    //El constructor dandole la cantidad X y Y
    public MatrizCadena(int cantX, int cantY)
    {
        //Dimensionar la matriz
        M = new string[cantX, cantY];
        columna = cantX;
        fila = cantY;
    }

    //Cargar la matriz con valores por defecto
    public void CargarMatrizDefault()
    {
        //Dar valores por defecto a la matriz
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[y, x] = defaultValue;
            }
        }
    }
    //Mostrar el contenido de la matriz
    public void MostrarMatriz()
    {
        string res = "";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                string dato = M[y, x];
                res = res + dato + " , ";
            }
            res = res + "\n";
        }
        Console.WriteLine(res);
    }

    public void LlenarMatriz_v1()
    {
        string dato = "UPC";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato;
            }
            dato = dato + "_" + i;
            i++;
        }
    }

}