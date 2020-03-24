using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EntradaDeProduto
{
    class Produto
    {
        private string _nome;
        private int _quantidade;
        private double _preco;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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

        public double Preco
        {
            get { return _preco; }
        }

        public double Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEstoque
        {
            get { return _quantidade * _preco; }
        }

        public void AdicionarAoEstoque()
        {
            Console.Write("Digite o numero de produtos a serem adicionados:");
            _quantidade += int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            DadosDoProduto();           
        }

        public void RemoverDoEstoque()
        {
            Console.Write("Digite o numero de produtos a serem removidos:");
            _quantidade -= int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
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
