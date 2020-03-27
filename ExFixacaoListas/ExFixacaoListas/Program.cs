using System;
using System.Collections.Generic;

namespace ExFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            Console.Write("Quantos empregados serão registrados: ");
            int totalfuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i<totalfuncionarios; i++)
            {
                int j = i + 1;
                Console.WriteLine("Funcionário: " + j );
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                funcionario.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o ID do funcionário que receberá aumento: ");
            int idProcura = int.Parse(Console.ReadLine());
            Console.Write("Informe a porcentagem do aumento: ");
            int aumento = int.Parse(Console.ReadLine());

            Funcionario funcionarioBusca = funcionario.Find(x => x.ID == idProcura);
            if (funcionarioBusca != null)
            {
                Console.Write("Informe a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                funcionarioBusca.Aumento(porcentagem);

            }
            else
                Console.WriteLine("Este funcionario não existe!!");


            Console.WriteLine();
            Console.WriteLine("Lista de funcionarios atulizada: ");
            foreach (Funcionario obj in funcionario)
            {
                Console.WriteLine(obj);
            }
            
            
        }
    }
}
