using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacaoListas
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public  double Salario { get; set; }

        public Funcionario(int iD, string nome, double salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
        }
           
        public void Aumento(int id, double porcentagem)
        {
            Salario += porcentagem * Salario;

        }
    
    
    }
}
