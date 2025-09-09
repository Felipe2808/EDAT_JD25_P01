internal class Program
{
    private static void Main(string[] args)
    {
      
        Recursiv_Actividad1.Recursividad1 recursividad = new Recursiv_Actividad1.Recursividad1();

        // 1 Vocales
       
        Console.WriteLine("Ingrese una cadena de texto:");
        string cadena = Console.ReadLine();
        int cantidadVocales = recursividad.vocales(cadena);
        Console.WriteLine("La cantidad de vocales en la cadena es: " + cantidadVocales);

        // 2 Suma de dígitos
      
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());
        int suma = recursividad.sumaDigitos(numero);
        Console.WriteLine("La suma de los dígitos del número es: " + suma);

        // 3 Suma de los primeros n números
       
        Console.WriteLine("Ingrese un número n:");
        int n = int.Parse(Console.ReadLine());
        int sumaN = recursividad.sumaN(n);
        Console.WriteLine("La suma de los primeros " + n + " números es: " + sumaN);
    }
}