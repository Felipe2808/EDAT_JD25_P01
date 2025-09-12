internal class Program
{
    public static void Main(string[] args)
    {
        /*
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
        //LO MISMO PERO CON EL CICLO FOR
     
        */
        RecursividadAC.Recursividad recursividad = new RecursividadAC.Recursividad();



       

        // Factorial con FOR
        Console.WriteLine("\nFactorial de un numero (FOR)");
        Console.Write("Ingrese el numero: ");
        int numeroFor = int.Parse(Console.ReadLine());
        Console.WriteLine("El factorial es: " + recursividad.factorialFor(numeroFor));

       

        // Fibonacci con FOR
        Console.WriteLine("\nSerie Fibonacci (FOR)");
        Console.Write("Ingrese la posicion: ");
        int num2For = int.Parse(Console.ReadLine());
        Console.WriteLine("Resultado: " + recursividad.fibonacciFor(num2For));

        

        // Revertir número con FOR
        Console.WriteLine("\nRevertir numero (FOR)");
        Console.Write("Ingrese el numero: ");
        string num3For = Console.ReadLine();
        Console.WriteLine("Invertido: " + recursividad.revertirFor(num3For));

       

        // Imprimir letras con FOR
        Console.WriteLine("\nImprimir letras (FOR)");
        Console.Write("Ingrese la primer letra: ");
        char inicioFor = Convert.ToChar(Console.ReadLine());
        Console.Write("Ingrese la segunda letra: ");
        char finFor = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Letras: " + recursividad.imprimirFor(inicioFor, finFor));
        





    }
}