using System;
using System.Globalization;

namespace EntradaDeProduto
{
    class EntryPoint

    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.InformarDados();
            produto.DadosDoProduto();
            produto.AdicionarAoEstoque();
            produto.RemoverDoEstoque();
        }
    }
}
