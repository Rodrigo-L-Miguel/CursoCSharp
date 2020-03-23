using System;

namespace AtvFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Nome do Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final: " + aluno.NotaFinal());
            aluno.Aprovacao();
        }
    }
}
