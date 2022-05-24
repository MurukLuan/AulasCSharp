using System;

namespace ExceptionsAula_23_05_2022.Entities.Exceptions
{
    class ExcecaoProduto : ApplicationException
    {
        public ExcecaoProduto(string message) : base(message)
        {

        }
    }
}
