using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejemplo = 15;
            List<int> numeros = Numeros(ejemplo);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static List<int> Numeros(int ejemplo)
        {
            List<int> result = new List<int>();
            int inicio = 1;
            int fin = 1;
            int suma = 0;
            // mientras inicio sea menor que ejemplo
            while (suma <= ejemplo)
            {
                if (suma < ejemplo)
                {
                    suma += fin;
                    fin++;
                }
                else
                {
                    for (int i = inicio; i < fin; i++)
                    {
                        result.Add(i);

                    }
                    break;
                }
            }
 
            return result;
        }
    }
}

/* 
 * 
 * Dado un número entero positivo, se necesita encontrar una lista de números
 * consecutivos que, al ser sumados, alcancen dicho número. Se busca una solución 
 * eficiente que proporcione la lista de números mínima necesaria para alcanzar el objetivo.

Ejemplo:
Dado el número 15, se busca encontrar la lista de números consecutivos que sumados alcancen este objetivo.

*/