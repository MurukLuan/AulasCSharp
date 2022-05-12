using System;
using System.Collections.Generic;
using System.Text;

namespace IntoduçãoHerança
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public EstadoPedido EstadoDoPedido { get; set; }

        public void Status(int valor)
        {
            EstadoDoPedido = (EstadoPedido)valor;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Data: " + Data + "Estado do pedido: " + EstadoDoPedido;
        }
    }
}
