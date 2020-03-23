using System;
using System.Collections.Generic;
using System.Text;

namespace AtvFixacao1
{
    class Retangulo
    {
        protected double Largura;
        protected double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * Largura + 2 * Altura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
