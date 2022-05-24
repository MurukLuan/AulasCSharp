using IntroducaoExcecoes.Entities.Exceptions;
using System;

namespace IntroducaoExcecoes.Entities
{
    class Produto
    {
        public int Identificador { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(int identificador, string nomeProduto, double preco, int quantidade)
        { 
            Identificador = identificador;
            NomeProduto = nomeProduto;
            Preco = preco;
            Quantidade = quantidade;

            if (Identificador.Equals(null) || Identificador == 0)
            {
                throw new ExceptionVenda("O identificador não pode ser zero.");
            }
            if (NomeProduto == "" || NomeProduto.Length < 2)
            {
                throw new ExceptionVenda("O nome do produto não pode ser vazio ou conter menos que 2 caracteres");
            }

        }

        public override string ToString()
        {
            return "id produto: " + Identificador
                + "\nNome produto: " + NomeProduto
                + "\nPreço produto: " + Preco
                + "\nQuantidade: " + Quantidade;
        }

    }
}
