using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EntradaDeProduto
{
    class Produto
    {
        private string Nome;
        private int Quantidade;
        private double Preco;

        public  Produto(string nome,double preco,int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        
        public double ValorTotalEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarAoEstoque()
        {
            Console.Write("Digite o numero de produtos a serem adicionados:");
            Quantidade += int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            DadosDoProduto();           
        }

        public void RemoverDoEstoque()
        {
            Console.Write("Digite o numero de produtos a serem removidos:");
            Quantidade -= int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            DadosDoProduto();
        }

        public void DadosDoProduto()
        {
            Console.WriteLine("Dados do produto:"
                +Nome+ " Preço: $"
                +Preco+" Quantidade: "
                +Quantidade+ " Valor total:" + ValorTotalEstoque());
        }

    }
}
