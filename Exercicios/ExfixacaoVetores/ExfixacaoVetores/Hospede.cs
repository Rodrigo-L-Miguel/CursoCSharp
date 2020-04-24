using System;
using System.Collections.Generic;
using System.Text;

namespace ExfixacaoVetores
{
    class Hospede
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Nome: " + Nome + ", E-mail: " + Email;
        }
    }
}
