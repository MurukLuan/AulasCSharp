using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExplicacaoSimples.Entities
{
    public abstract class CarroFactoryMethod
    {
        public Carro MontarCarro(string tipo)
        {
            Carro carro;
            carro = CriarCarroSimpleFactory(tipo);
            return carro;
        }
        protected abstract Carro CriarCarro(string tipo);
    }
}
