using System;

namespace AulaDesignPatternsERevisao_27_05_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            Conta cc = new ContaCorrente();
            Conta cp = new ContaPoupanca();

            conta.Depositar(200.00);
            cc.Depositar(500.00);
            cp.Depositar(900.00);

            Console.WriteLine("Saldo da classe conta: " + conta.Saldo);
            Console.WriteLine("Saldo da conta corrente: " + cc.Saldo);
            Console.WriteLine("Saldo da conta poupança: " + cp.Saldo);

            conta.Sacar(100.00);
            cc.Sacar(100.00);
            cp.Sacar(100.00);
            Console.WriteLine("\nDepois do saque: \n");

            Console.WriteLine("Saldo da classe conta: " + conta.Saldo);
            Console.WriteLine("Saldo da conta corrente: " + cc.Saldo);
            Console.WriteLine("Saldo da conta poupança: " + cp.Saldo);
        }
    }
}
