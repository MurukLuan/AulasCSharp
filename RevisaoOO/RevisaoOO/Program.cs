using System;

namespace RevisaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Entre com o nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Entre com a altura: ");
            pessoa1.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(pessoa1.Nome, pessoa1.Idade, pessoa1.Altura, "(61)98342-8392");

            Console.WriteLine(pessoa);
        }
    }
}
