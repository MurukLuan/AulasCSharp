using System;

namespace AulaRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double preco;
            char opcao;

            Console.WriteLine("Digite o nome da pessoa: ");
            nome = Console.ReadLine();

            Console.WriteLine("Entre com a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Voce é casado? (s/n): ");
            opcao = char.Parse(Console.ReadLine());

            Console.WriteLine("O nome digitado foi: " + nome + " " + idade + " " + preco + " " + opcao);
        }
    }
}
