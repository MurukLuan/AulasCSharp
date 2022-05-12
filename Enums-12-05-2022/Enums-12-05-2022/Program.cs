using System;
using Enums_12_05_2022.Entities;
using Enums_12_05_2022.Entities.Enums;

namespace Enums_12_05_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            Pedido pedido = new Pedido(DateTime.Now);

            Console.WriteLine("entre com numero do pedido: ");
            pedido.NumeroPedido = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o item: ");
            pedido.Item = Console.ReadLine();

            pedido.Data = DateTime.Now;

            Console.WriteLine("Entre com o estado do pedido: ");
            int opt = int.Parse(Console.ReadLine());
            pedido.PedidoStatus = (EstadoPedido)2;

            Console.WriteLine(pedido);
            

            /*long cpf = 12345678910;

            Console.WriteLine(cpf.ToString(@"000\.000\.000\-00"));
            Console.WriteLine(cpf.ToString(string.Format(@"000\.000\.000\-00")));*/
        }
    }
}
