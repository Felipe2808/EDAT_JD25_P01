using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursiv_Actividad1
{
   
        public class Recursividad1
        {
            // 1) Contar vocales 
            public int vocales(string cadena)
            {
                if (cadena.Length == 0)
                {
                    return 0;
                }

                char primero = char.ToLower(cadena[0]);
                int esVocal = (primero == 'a' || primero == 'e' || primero == 'i' || primero == 'o' || primero == 'u') ? 1 : 0;

                return esVocal + vocales(cadena.Substring(1));
            }

            // 2) Suma de dígitos 
            public int sumaDigitos(int numero)
            {
                if (numero < 10)
                {
                    return numero;
                }

                return (numero % 10) + sumaDigitos(numero / 10);
            }

            // 3) Suma de los primeros n números 
            public int sumaN(int n)
            {
                if (n == 1)
                {
                    return 1;
                }

                return sumaN(n - 1) + n;
            }
        }
    }

