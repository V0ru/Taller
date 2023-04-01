using System;
namespace Puntoo2
{
     class P2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            string rangoEdad = "";

            if (edad >= 0 && edad < 2)
            {
                rangoEdad = "Bebe";
            }
            else if (edad >= 2 && edad < 12)
            {
                rangoEdad = "Niño";
            }
            else if (edad >= 12 && edad < 18)
            {
                rangoEdad = "Adolescente";
            }
            else if (edad >= 18 && edad < 30)
            {
                rangoEdad = "Adulto Joven";
            }
            else if (edad >= 30 && edad < 65)
            {
                rangoEdad = "Adulto";
            }
            else if (edad >= 65)
            {
                rangoEdad = "Tercera Edad";
            }

            Console.WriteLine("Usted pertenece al rango de edad: " + rangoEdad);
        }
    }
}