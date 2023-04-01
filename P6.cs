using System;
namespace Punto6
{
     class P6
    {
        static void Main(string[] args)
        {
            string[] diasTrabajo = new string[] { "lunes", "martes", "miércoles", "jueves", "viernes", "sábado", "domingo" };
            int diasLaborables = 0;
            int diasFinSemana = 0;

            Console.WriteLine("Ingrese los días de trabajo del empleado (separados por comas):");
            string[] diasEmpleado = Console.ReadLine().Split(",");

            for (int i = 0; i < diasEmpleado.Length; i++)
            {
                if (Array.IndexOf(diasTrabajo, diasEmpleado[i].ToLower()) >= 0)
                {
                    if (diasEmpleado[i].ToLower() == "sábado" || diasEmpleado[i].ToLower() == "domingo")
                    {
                        diasFinSemana++;
                    }
                    else
                    {
                        diasLaborables++;
                    }
                }
            }

            Console.WriteLine("Días laborables: " + diasLaborables);
            Console.WriteLine("Días fin de semana: " + diasFinSemana);
            Console.ReadKey();
        }
    }
}