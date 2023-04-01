using System;
namespace Punto4
{
     class P4
    {
        private double FuncionPorPartes(double x)
        {
            if (x <= 0)
            {
                return 0;
            }
            else
            {
                return Math.Pow(x, 2);
            }
        }
    }
}