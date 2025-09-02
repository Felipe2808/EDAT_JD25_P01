using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)


    {

        //1.-calcular promedio de un areglo
        var numeross= new List<int>() { 45, 22, 53, 500, 2000, 10000, 0, 1 };
        Func<List<int>, double> promedio = (lista) => lista.Sum() / (double)lista.Count;
        Console.WriteLine("El promedio del areglo es:"+promedio(numeross));
        Console.WriteLine("\n\n\n\n");
        //2.-menor de un areglo

        var num = new List<int>() { 8, 5, 9, 34, 2, 26, 8 };
        var numMenor = (List<int> areglo) => {
            if (areglo == null || areglo.Count == 0)
            {
                return 0;
            }
            int menor = areglo[0];
            for (int i = 1; i < areglo.Count; i++)
            {
                if (areglo[i] < menor)
                {
                    menor = areglo[i];
                }
            }
            return menor;
        };
        int menor = numMenor(num);
        Console.WriteLine("el numero menor es:" + menor);
        Console.WriteLine("\n\n\n\n");
        //3.-numero mayor de 3 numeros

        Func<int, int, int, int> mayor = (a, b, c) =>
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= a && b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }


        };
        int may = mayor(1, 2, 4);
        Console.WriteLine("El numero mayor es:"+may);
        Console.WriteLine("\n\n\n\n");
        //4.-string y numeron entero retornar la multiplicacion de los dos
        Func<String, int, String> mult = (texto, numero) =>
        {
            String res = "";
            for(int i = 0; i < numero; i++)
            {
                res = res + texto;
            }  
            return res;
        };
        String rep = mult("d", 3);
        Console.WriteLine("la multiplicacion es:"+rep);


        Console.ReadKey();


    }
}