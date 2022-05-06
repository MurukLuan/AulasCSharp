using System;

namespace IntroducaoConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com o nome do protudo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Produtos prod = new Produtos() {Nome = nome, Preco = preco, Quantidade = 3 };

            Console.WriteLine(prod);
        }
    }
}
