using System;

namespace AtividadeBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("Entre com o nome: ");
            conta.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o numero da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a idade: ");
            conta.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Seu saldo atual é de: " + conta.Saldo);

            Console.Write("Qual o valor que deseja depositar: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);

            Console.WriteLine("Seu saldo atual é de: " + conta.Saldo);

            Console.Write("Qual o valor que deseja sacar: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);

            Console.WriteLine("Seu saldo atual é de: " + conta.Saldo);

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Numero da conta: " + conta.NumeroConta);
            Console.WriteLine("Nome: "+ conta.Nome);
            Console.WriteLine("Idade: " + conta.Idade);
            Console.WriteLine("Saldo: " + conta.Saldo);
            
        }
    }
}
