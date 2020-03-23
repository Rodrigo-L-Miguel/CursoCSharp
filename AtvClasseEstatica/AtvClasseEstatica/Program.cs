using System;
using System.Globalization;
namespace AtvClasseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dollar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dollares você vai comprar?");
            double valor= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.ConverterDollar(valor,cotacao));



        }
    }
}
