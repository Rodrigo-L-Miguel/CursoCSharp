using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EntradaDeProduto
{
    class Produto
    {
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }

        }

        public double ValorTotalEstoque
        {
            get { return Quantidade * Preco; }
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
                +Quantidade+ " Valor total:" + ValorTotalEstoque);
        }

    }
}
