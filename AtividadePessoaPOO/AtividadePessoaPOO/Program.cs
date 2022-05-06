using System;

namespace AtividadePessoaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Entre com a idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a altura: ");
            pessoa1.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o peso: ");
            pessoa1.Peso = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o nome da pessoa: ");
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine("Entre com a idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a altura: ");
            pessoa2.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o peso: ");
            pessoa2.Peso = double.Parse(Console.ReadLine());

            if(pessoa1.Peso > pessoa2.Peso)
            {
                Console.WriteLine(pessoa1.Nome + " é o mais pesado, seu peso: " + pessoa1.Peso);
            }
            else
            {
                Console.WriteLine(pessoa2.Nome + " é o mais pesado, seu peso: " + pessoa2.Peso);
            }

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine(pessoa1.Nome + " é o mais velho, sua idade: " + pessoa1.Idade);
            }
            else
            {
                Console.WriteLine(pessoa2.Nome + " é o mais velho, sua idade: " + pessoa2.Idade);
            }
        }
    }
}
