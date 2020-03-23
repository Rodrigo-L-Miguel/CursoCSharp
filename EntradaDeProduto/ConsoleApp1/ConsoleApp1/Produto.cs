using System;
using System.Collections.Generic;
using System.Text;

namespace EntradaDeProduto
{
    class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public double ValorTotalEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarAoEstoque(int quantidadeAdicionar)
        {
            Quantidade += quantidadeAdicionar;
        }

        public void RemoverDoEstoque(int quantidadeRemover)
        {
            Quantidade -= quantidadeRemover;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco + ", " + Quantidade + " unidades, Total: $" + ValorTotalEstoque();
        }

    }
}
