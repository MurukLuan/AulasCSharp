using System;

namespace ExercicioPropertiesBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta = new Conta();

            Console.WriteLine("Entre com o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o numero da agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero da conta: ");
            int contas = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem deposito: ");
            char opcao = char.Parse(Console.ReadLine());

            if(opcao == 's')
            {
                Console.WriteLine("Entre com o valor do deposito: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor); 
            }

            Console.WriteLine("Quer sacar: ");
            char opcaoSaque = char.Parse(Console.ReadLine());

            if (opcao == 's')
            {
                Console.WriteLine("Entre com o valor do saque: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Sacar(valor);
            }

            Conta c = new Conta(contas, agencia, nome);

            Console.WriteLine("Nome: " + conta.Nome);
            Console.WriteLine("Agencia: " + conta.Agencia + " Conta: " + conta.NumeroConta);
            Console.WriteLine("Saldo disponivel: " + conta.Saldo);

        }
    }
}
