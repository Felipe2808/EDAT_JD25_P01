using System.Runtime.CompilerServices;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Recursividad");
        Console.WriteLine("Casos de recursividad");
        Console.WriteLine("caso 1"); 
        Recursividad.Logica.Recursividad recursividad = new Recursividad.Logica.Recursividad();
        int resultado = recursividad.Factorial(6);
        Console.WriteLine("el factorial es: "+resultado);
        Console.WriteLine("caso 2");
        int resultado2 = recursividad.Potencia(3, 4);
        Console.WriteLine("el resultado es:"+resultado2);




        Console.ReadKey();
    }
}