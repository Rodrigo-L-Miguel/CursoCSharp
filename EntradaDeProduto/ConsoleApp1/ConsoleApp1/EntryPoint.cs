using System;
using System.Globalization;

namespace EntradaDeProduto
{
    class EntryPoint

    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome,preco,quantidade);

            produto.DadosDoProduto();
            produto.AdicionarAoEstoque();
            produto.RemoverDoEstoque();
        }
    }
}
