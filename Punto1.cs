using System;
namespace TallerProgramacion3
{
    class Punto1
    {
        static void Main(string[] args)
        {
            const int precioUnitario = 650;
            const double descuento = 0.3;

            Console.Write("Ingrese la cantidad de jeans que comprará: ");
            int cantidad = int.Parse(Console.ReadLine());

            int precioTotal = cantidad * precioUnitario;

            if (cantidad > 2)
            {
                precioTotal = (int)(precioTotal * (1 - descuento));
            }

            Console.WriteLine("El precio a pagar es: $" + precioTotal);
        }
    }
    }