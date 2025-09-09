internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Factorial de un numero");
        RecursividadAC.Recursividad recursividad = new RecursividadAC.Recursividad();
        Console.WriteLine("ingrese el numero para el factorial");
        int numero=int.Parse(Console.ReadLine());
        Console.WriteLine("el factorial de el numero es"+recursividad.factorial(numero));
        Console.WriteLine("serie fibonacci");
        Console.WriteLine("ingrese una posicion de la sumatoria fibonacci");
        int num2=int.Parse(Console.ReadLine());
        Console.WriteLine("la posicion es:"+recursividad.fibonacci(num2));
        Console.WriteLine("Ingrese los numeros a revertir");
        string num3=Console.ReadLine();
        Console.WriteLine("la cantidad invertida es"+recursividad.revertir(num3));
        Console.WriteLine("ingrese la primer letra");
        char inicio =Convert.ToChar( Console.ReadLine());
        Console.WriteLine("ingrese la segunda letra");
        char fin = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("las letras son: "+recursividad.imprimir(inicio,fin));



    }
}