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

    }
}
