using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadAC
{
    public class Recursividad
    {
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
        public string impfor(char inicio, char fin)
        {
            if (inicio == fin)
            {
                return inicio.ToString();
            }
            else
            {
                for (int i=0;i==27; i++)
                {
                    if (i==inicio)
                    {
                        return inicio +","+impfor((char)(inicio + 1), fin);
                    }

                }
            }
               
        }

    }
}
