using System;
using System.Collections.Generic;
using System.Text;

namespace AtvClasseEstatica
{
    class ConversorDeMoeda
    {
        static double IOF = 0.06;

        static double ConverterDollar(double valor,double cotacao)
        {

            return valor * cotacao * IOF;

        }

    }
}
