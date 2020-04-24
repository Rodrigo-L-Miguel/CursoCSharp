using System;
using System.Globalization;

namespace AtvFixacao1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a altura e largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + retangulo.Area());
            Console.WriteLine("Perimetro = " + retangulo.Perimetro());
            Console.WriteLine("Diagonal = " + retangulo.Diagonal());



        }
    }
}
