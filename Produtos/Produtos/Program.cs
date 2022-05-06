using System;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.Write("Digite o identificador do produto: ");
            produto.Identificador = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Entre com o preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Entre com a quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(produto);

            Console.WriteLine("Entre com a quantidade do produto que deseja adicionar: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(qtd);

            Console.WriteLine("Qtd atualizada inserido: ");
            Console.WriteLine(produto);

            Console.WriteLine("Entre com a quantidade do produto que deseja remover: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProduto(qtd);

            Console.WriteLine("Qtd atualizada removido: ");
            Console.WriteLine(produto);

            //chama metodo que calcula o valor em estoque
            //Console.WriteLine("Valor total em estoque: " + produto.ValorTotalEstoque());
        }
    }
}
