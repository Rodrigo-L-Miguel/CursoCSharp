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
            produto.DadosDoProduto();
            produto.AdicionarAoEstoque();
            produto.RemoverDoEstoque();
        }
    }
}
