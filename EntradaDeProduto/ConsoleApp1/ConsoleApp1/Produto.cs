using System;
using System.Collections.Generic;
using System.Text;

namespace EntradaDeProduto
{
    class Produto
    {
        public string Nome;
        public int TotalEstoque;
        public double Preco;

        public double ValorTotalEstoque()
        {
            return TotalEstoque * Preco;
        }

        public int AdicionarAoEstoque(int quantidadeAdicionar)
        {
            TotalEstoque += quantidadeAdicionar;
            return TotalEstoque;
        }

        public int RemoverProduto (int quantidadeRemover)
        {
            TotalEstoque -= quantidadeRemover;
            return TotalEstoque;
        }
    }
}
