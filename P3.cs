using System;
namespace Punto3
{
    class P3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la operación a realizar (1: suma, 2: resta, 3: multiplicación, 4: división): ");
            int operacion = int.Parse(Console.ReadLine());

            double resultado;

            switch (operacion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operación inválida.");
                    return;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}