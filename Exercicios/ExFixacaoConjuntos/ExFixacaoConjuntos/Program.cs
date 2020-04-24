using System;
using System.Collections.Generic;

namespace ExFixacaoConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> conjA = new HashSet<int>();
            HashSet<int> conjB = new HashSet<int>();
            HashSet<int> conjC = new HashSet<int>();

            Console.WriteLine("O curso A possui quantos alunos? ");
            int totalAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id dos alunos:");

            for (int i = 0; i < totalAlunos; i++)
            {
                int id = int.Parse(Console.ReadLine());
                conjA.Add(id);
            }

            Console.WriteLine("O curso B possui quantos alunos? ");
            totalAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id dos alunos:");

            for (int i = 0; i < totalAlunos; i++)
            {
                int id = int.Parse(Console.ReadLine());
                conjB.Add(id);
            }

            Console.WriteLine("O curso C possui quantos alunos? ");
            totalAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id dos alunos:");

            for (int i = 0; i < totalAlunos; i++)
            {
                int id = int.Parse(Console.ReadLine());
                conjC.Add(id);
            }

            HashSet<int> solucao = new HashSet<int>();
            solucao.UnionWith(conjA);
            solucao.UnionWith(conjB);
            solucao.UnionWith(conjC);

            Console.WriteLine("Total de alunos: " + solucao.Count);
            




        }
    }
}
