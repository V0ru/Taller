using System;
namespace Punto5
{
     class P5
    {
        static void Main(string[] args)
        {
            int uno = 0;
            int cinco = 0;
            int diez = 0;
            int otros = 0;

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                int valor = rnd.Next(1, 11);

                if (valor == 1)
                {
                    uno++;
                }
                else if (valor == 5)
                {
                    cinco++;
                }
                else if (valor == 10)
                {
                    diez++;
                }
                else
                {
                    otros++;
                }
            }

            Console.WriteLine("Cantidad de valores generados:");
            Console.WriteLine("1: " + uno);
            Console.WriteLine("5: " + cinco);
            Console.WriteLine("10: " + diez);
            Console.WriteLine("Otros: " + otros);

            Console.ReadKey();
        }
    }
}
