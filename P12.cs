using System;
using System.Collections.Generic;

namespace Punto12
{
     class P12
    {
        List<Cuenta> list = new List<Cuenta>();
        double sumatoria = 0;
        enum Estado { Acreedor = 1, Deudor = 2, Nulo = 3 };

        string titulo = "===============>> PROGRAMA QUE CONTROLA CUENTAS CORRIENTES <<===============\n";


        public void Ejercicio4_1()
        {
            Cuenta c = null;

            do
            {
                Console.WriteLine(titulo);
                Console.WriteLine("**Para detener ingrese un valor negativo");
                c = new Cuenta();
                Console.WriteLine("Ingrese el numero de cuenta corriente: ");
                c.CuentaCorriente = Convert.ToInt32(Console.ReadLine());
                if (c.CuentaCorriente < 0)
                {
                    break;
                }
                Console.WriteLine("Ingrese el saldo actual de la cuenta");
                c.SaldoActual = Convert.ToDouble(Console.ReadLine());
                if (c.SaldoActual > 0)
                    c.EstadoCuenta = Estado.Acreedor.ToString();
                else if (c.SaldoActual < 0)
                    c.EstadoCuenta = Estado.Deudor.ToString();
                else c.EstadoCuenta = Estado.Nulo.ToString();

                list.Add(c);
                Console.Clear();

            }
            while (c.CuentaCorriente > 0);

            Console.WriteLine(titulo);

            foreach (Cuenta cuenta in list)
            {
                Console.WriteLine("La cuenta {0} tiene un estado de: {1} ", cuenta.CuentaCorriente, cuenta.EstadoCuenta);
                if (cuenta.EstadoCuenta == Estado.Acreedor.ToString())
                    sumatoria += cuenta.SaldoActual;
            }

            Console.WriteLine("La sumatoria del saldo total de los acreedores es de: ${0} ", sumatoria);

        }
    }

    class Cuenta
    {
        public int CuentaCorriente { get; set; }
        public double SaldoActual { get; set; }
        public string EstadoCuenta { get; set; }
    }
}
