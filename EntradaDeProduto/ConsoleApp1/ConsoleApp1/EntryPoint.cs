using System;
using System.Globalization;

namespace EntradaDeProduto
{
    class EntryPoint

    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados:");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.AdicionarAoEstoque(qte);
            Console.WriteLine("Dados atualizado: " + produto);
            Console.Write("Digite o numero de produtos a serem removidos:");
            qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.RemoverDoEstoque(qte);
            Console.WriteLine("Dados atualizado: " + produto);



        }
    }
}
