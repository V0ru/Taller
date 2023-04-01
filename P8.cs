using System;
namespace Punto8
{
     class P8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de alturas a ingresar:");
            int n = Convert.ToInt32(Console.ReadLine());

            double sumaAlturas = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese la altura de la persona #" + (i + 1) + ":");
                double altura = Convert.ToDouble(Console.ReadLine());
                sumaAlturas += altura;
            }

            double alturaPromedio = sumaAlturas / n;

            Console.WriteLine("La altura promedio es: " + alturaPromedio);

            Console.ReadKey();
        }
    }
}