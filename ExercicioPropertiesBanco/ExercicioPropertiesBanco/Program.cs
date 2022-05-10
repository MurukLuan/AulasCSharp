using System;

namespace ExercicioPropertiesBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            do
            {
                Conta conta = new Conta();

                Console.Write("Entre com o nome do titular da conta: ");
                conta.Nome = Console.ReadLine();

                Console.Write("Entre com o numero da agencia: ");
                conta.Agencia = int.Parse(Console.ReadLine());

                Console.Write("Entre com o numero da conta: ");
                conta.NumeroConta = int.Parse(Console.ReadLine());

                Console.Write("Deseja realizar um deposito? (s/n): ");
                opcao = char.Parse(Console.ReadLine());

                double valor = 0;
                if (opcao == 's')
                {
                    Console.Write("Entre com o valor do deposito: ");
                    valor = double.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                }

                Console.Write("Deseja realizar um saque? (s/n): ");
                opcao = char.Parse(Console.ReadLine());

                if (opcao == 's')
                {
                    Console.Write("Qual o valor que deseja sacar: ");
                    valor = double.Parse(Console.ReadLine());

                    if (conta.Saldo >= valor)
                    {
                        conta.Sacar(valor);
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente! seu saldo atual é de: " + conta.Saldo);
                    }
                }

                Console.WriteLine(conta);

                Console.WriteLine("Deseja realizar outro cadastro? (s/n) ");
                opcao = char.Parse(Console.ReadLine());
            } while (opcao == 's');


        }
    }
}
