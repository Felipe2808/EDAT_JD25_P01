using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadAC
{
    public class Recursividad
    {
        /*
        public int factorial(int numero)
        {
            //Caso base
            if (numero == 1 || numero == 0)
            {
                return 1;
            }

            //Caso general
            return numero * factorial(numero - 1);

        }
        public int fibonacci(int posicion)
        {
            if (posicion == 0)
            {
                return 0;
            }
            if (posicion == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(posicion - 1) + fibonacci(posicion - 2);
            }
        }
        public string revertir(string numero)
        {
            if (numero.Length == 1)
            {
                return numero;
            }
            else
            {
                return numero[numero.Length - 1] + revertir(numero.Substring(0, numero.Length - 1));
            }
        }
        public string imprimir(char inicio, char fin)
        {
            if (inicio == fin)
            {
                return inicio.ToString();
            }
            else
            {
                return inicio + ", " + imprimir((char)(inicio + 1), fin);
            }
        }

        */
        // Factorial con FOR
        public int factorialFor(int numero)
        {
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        // Fibonacci con FOR
        public int fibonacciFor(int posicion)
        {
            if (posicion == 0) return 0;
            if (posicion == 1) return 1;

            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= posicion; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

        // Revertir número con FOR
        public string revertirFor(string numero)
        {
            string invertido = "";
            for (int i = numero.Length - 1; i >= 0; i--)
            {
                invertido += numero[i];
            }
            return invertido;
        }

        // Imprimir letras con FOR
        public string imprimirFor(char inicio, char fin)
        {
            string resultado = "";
            for (char c = inicio; c <= fin; c++)
            {
                resultado += c;
                if (c != fin) resultado += ", ";
            }
            return resultado;
        }



    }
}
