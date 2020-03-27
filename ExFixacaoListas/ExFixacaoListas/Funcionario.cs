using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacaoListas
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public  double Salario { get; private set; }

        public Funcionario(int iD, string nome, double salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
        }
           
        public void Aumento( double porcentagem)
        {
            Salario += Salario*porcentagem/100;

        }

        public override string ToString()
        {
            return ID + ", " + Salario;
        }

    }
}
