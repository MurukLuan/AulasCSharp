using System;

namespace IntoduçãoHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(1425, "Luan Muruk");
            ContaPoupanca poupanca = new ContaPoupanca("Luan Tonaco", 1426, 25.00);

            Console.WriteLine(poupanca.Saldo);
            Console.WriteLine(conta.Saldo);

            Console.WriteLine("Entre com o valor a ser depositado: ");
            double valor = double.Parse(Console.ReadLine());

             conta.Depositar(1100.25);
             poupanca.Depositar(valor + poupanca.Rendimento);

             Console.WriteLine(poupanca.Saldo);
             Console.WriteLine(conta.Saldo);

            /*Pedido pedido = new Pedido()
            {
                Id = 1020,
                Data = DateTime.Now,
                EstadoDoPedido = EstadoPedido.confirmado
            };

            Console.WriteLine(pedido);

            Console.WriteLine("Entre com o numero do pedido: ");
            pedido.Id = int.Parse(Console.ReadLine());

            Console.Write("Estado do pedido (0,1,2,3): ");
            int opt = int.Parse(Console.ReadLine());
            pedido.Status(opt);
            pedido.Data = DateTime.Now;



            Console.WriteLine(pedido);*/

            long cpf = 01234567891;


            Console.WriteLine(cpf.ToString(@"000\.000\.000\-00"));
            Console.WriteLine(cpf.ToString(string.Format(@"000\.000\.000\-00")));
        }
    }
}
