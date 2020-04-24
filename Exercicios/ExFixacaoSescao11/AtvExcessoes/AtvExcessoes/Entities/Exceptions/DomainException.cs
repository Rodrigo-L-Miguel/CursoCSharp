using System;


namespace AtvExcessoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensagem): base(mensagem)
        {
        }
    }
}
