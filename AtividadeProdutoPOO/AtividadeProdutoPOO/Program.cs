using System;

namespace AtividadeProdutoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Entre com o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o preco de custo do produto: ");
            produto.PrecoDeCusto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de venda: ");
            produto.PrecoDeVenda = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: ");
            Console.Write("Nome: " + produto.Nome
                           + "\nPreço de custo: " + produto.PrecoDeCusto
                           + "\nPreço de venda: " + produto.PrecoDeVenda);
        }
    }
}
