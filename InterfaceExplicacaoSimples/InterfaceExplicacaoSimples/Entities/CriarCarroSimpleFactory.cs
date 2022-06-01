using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExplicacaoSimples.Entities
{
    public class CriarCarroSimpleFactory
    {
        public static CarroFactoryMethod CriarCarro(string local)
        {
            CarroFactoryMethod carro;

            switch (local)
            {
                case "H":
                    carro = new CarroHatch();
                    break;

                case "S":
                    carro = new CarroSedan();
                    break;

                default:
                    throw new ApplicationException($"o carro do tipo {tipo} não pode ser pedido!");
            }

            return carro;
        }
    }
}
