using System;

namespace AulaRevisao_13_05_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(1234, "Luan");
            ContaJuridica cj = new ContaJuridica(1234, "JOao", 456, 456.55 );

            cj.Depositar(250.65);
            cj.Emprestimos(100.00);
            Console.WriteLine(cj.Saldo);


            //Console.WriteLine(Calculadora.Somar(2, 3));

            /*Console.WriteLine("Qual o estado do pedido: ");
            int estadoPedido = int.Parse(Console.ReadLine());

            conta.Status = (Enum)estadoPedido;
            Console.WriteLine(conta.Status);*/
        }
    }
}
