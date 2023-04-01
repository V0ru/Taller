using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto13
{
    internal class Empleado
    {
        private string nombre;
        private double sueldo;

        public void Cargar()
        {
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el sueldo del empleado: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void PagarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado " + nombre + " debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("El empleado " + nombre + " no debe pagar impuestos.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado();
            emp1.Cargar();
            emp1.Imprimir();
            emp1.PagarImpuestos();

            Console.ReadKey();
        }
    }
}