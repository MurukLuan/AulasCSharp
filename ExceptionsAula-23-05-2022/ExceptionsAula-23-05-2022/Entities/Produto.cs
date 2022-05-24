using System;
using ExceptionsAula_23_05_2022.Entities.Exceptions;

namespace ExceptionsAula_23_05_2022.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double valor { get; set; }


        Produto()
        {

        }

        public Produto(string nome, int quantidade, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            this.valor = valor;
        }

        public void VerificarErro(string nome)
        {
            if(nome.Length < 3)
            {
                throw new ExcecaoProduto("O nome não pode conter menos que 3 caractres!");
            }
        }
        public void VerificarErro(int quantidade)
        {
            if( quantidade <= 0)
            {
                throw new ExcecaoProduto("A quantidade não pode ser zero ou menor que zero!");
            }
        }

        public override string ToString()
        {
            return "Nome produto: " + Nome
                + "\nQuantidade cadastrada: " + Quantidade
                + "\nValor unitario: " + valor;
        }
    }
}
