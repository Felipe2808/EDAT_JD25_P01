using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ingrese un opcion\n1Leer matriz\n2matriz identidad\n3matriz n*m");
        int opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Leer matriz");
                //ercicio 1
                int[,] matriz = new int[3, 3];
                Console.WriteLine("Ingresa los valores de la matriz 3x3:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Elemento [{i},{j}]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine() ?? "0");
                    }
                }
                Console.WriteLine("\nLa matriz ingresada es:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                break;
            case 2:
                Console.WriteLine("Matriz identidad");
                //ejercicio 2
                int[,] Matriz2 = new int[4, 4];

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == j)
                        {
                            Matriz2[i, j] = 1;
                        }
                        else
                        {
                            Matriz2[i, j] = 0;
                        }
                    }
                }
                Console.WriteLine("\nLa matriz identidad 4x4 es:");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(Matriz2[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                break;
            case 3:
                Console.WriteLine("Matriz n*m");
                //ejercicio 3
                Console.WriteLine("ingrese de cunto por cuanto la matriz ");
                int n = int.Parse(Console.ReadLine());
                int m = n;
                int[,] Matriz3 = new int[n, m];
                Console.WriteLine("ingrese los datos de la matriz");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"Elemento [{i},{j}]: ");
                        Matriz3[i, j] = int.Parse(Console.ReadLine() ?? "0");
                    }

                }

                Console.WriteLine("los datos de la matriz m*n");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(Matriz3[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(" multiplicando la diagonal principal por 5 y ldemas que no sea eso por 15");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (i == j)
                        {
                            Matriz3[i, j] = Matriz3[i, j] * 5;
                        }
                        else
                        {
                            Matriz3[i, j] = Matriz3[i, j] * 15;
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(Matriz3[i, j] + "\t");
                    }
                    Console.WriteLine();
                }


                break;
            default:
                Console.WriteLine("opcion no valida");
                break;

        }







    }



}
