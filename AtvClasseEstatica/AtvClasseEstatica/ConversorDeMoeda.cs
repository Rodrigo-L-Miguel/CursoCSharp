using System;
using System.Collections.Generic;
using System.Text;

namespace AtvClasseEstatica
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double ConverterDollar(double valor,double cotacao)
        {

            return valor * cotacao * IOF;

        }

    }
}
