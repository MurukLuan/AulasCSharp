using System;
using System.Collections.Generic;
using System.Text;

namespace CorrecaoExercicioHP.Entities
{
    class ImovelNovo : Imovel
    {
        public ImovelNovo()
        {
        }

        public ImovelNovo(string endereco, double valor) : base(endereco, valor)
        {
        }

        public override void CalcularValor(double preco, double metroQuadrado)
        {
            base.CalcularValor(preco, metroQuadrado);
            Valor = preco * metroQuadrado  + (5000.00);
        }
    }
}
