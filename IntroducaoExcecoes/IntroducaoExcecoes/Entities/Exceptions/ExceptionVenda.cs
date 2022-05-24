using System;


namespace IntroducaoExcecoes.Entities.Exceptions
{
    class ExceptionVenda : ApplicationException
    {
        public ExceptionVenda(string message) : base(message)
        {

        }
    }
}
