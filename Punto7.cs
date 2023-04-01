using System;
namespace Punto2
{
     class Punto7
    {
        static void Main(string[] args)
        {
            int nota, numMayores = 0, numMenores = 0, numIguales = 0, contador = 0;
            Console.WriteLine("Introduzca 10 notas: ");
            while (contador < 10)
            {
                nota = int.Parse(Console.ReadLine());
                if (nota < 7)
                {
                    numMenores++;
                }
                else if (nota == 7)
                {
                    numIguales++;
                }
                else
                {
                    numMayores++;
                }
                contador++;
            }
            Console.WriteLine("Hay {0} inferiores a 7, {1} igual a 7 y {2} superiores a siete", numMenores, numIguales, numMayores);
        }
    }
}
