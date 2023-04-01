using System;

namespace Punto14
{
    internal class P14
    {
        static void Main(string[] args)
        {
            int n = 10; // ejemplo: cargar 10 elementos
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese un número para la posición {0}: ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            int menor = vector[0];
            bool repetido = false;

            for (int i = 1; i < n; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
                else if (vector[i] == menor)
                {
                    repetido = true;
                }
            }

            Console.WriteLine("El menor elemento es {0}", menor);

            if (repetido)
            {
                Console.WriteLine("El menor elemento se repite dentro del vector");
            }
            else
            {
                Console.WriteLine("El menor elemento no se repite dentro del vector");
            }
        }
    }
}
