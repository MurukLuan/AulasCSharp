using IntroducaoExcecoes.Entities;
using IntroducaoExcecoes.Entities.Exceptions;
using System;

namespace IntroducaoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Entre com o identificador numerico do produto: ");
                int idProd = int.Parse(Console.ReadLine());

                Console.Write("Entre com o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Entre com o valor do produto: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Entre com a quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(idProd, nome, preco, quantidade);

                Console.WriteLine(produto);
            }catch(ExceptionVenda e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
    }
}
