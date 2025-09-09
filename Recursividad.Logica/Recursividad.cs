 namespace Recursividad.Logica
{
    public class Recursividad
    {
        public int Factorial(int numero)
        {
            if (numero <= 1 )
            {
                return 1;
            }
            return numero * Factorial(numero - 1);



        }
        public int Potencia(int numero, int exponente)
        {
            if (exponente == 0)
            {
                return 1;
            }
            return numero * Potencia(numero, exponente - 1);
        }
    }
}
