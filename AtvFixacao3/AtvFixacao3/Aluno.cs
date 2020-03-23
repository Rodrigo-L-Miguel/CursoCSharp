using System;
using System.Collections.Generic;
using System.Text;

namespace AtvFixacao3
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public void Aprovacao()
        {
            if (NotaFinal() >= 60)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltam "+ (60 - NotaFinal()));
            }

        }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
    }
}
