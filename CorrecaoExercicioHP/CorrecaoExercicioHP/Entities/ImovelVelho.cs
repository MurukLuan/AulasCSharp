using System;
using System.Collections.Generic;
using System.Text;

namespace CorrecaoExercicioHP.Entities
{
    class ImovelVelho : Imovel
    {
        public ImovelVelho()
        {
        }

        public ImovelVelho(string endereco, double valor) : base(endereco, valor)
        {
        }

        public override void CalcularValor(double preco, double metroQuadrado)
        {
            base.CalcularValor(preco, metroQuadrado);

            Valor = preco * metroQuadrado - (2000.00);
        }
    }
}
