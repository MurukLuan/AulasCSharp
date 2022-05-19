using System;
using System.Collections.Generic;
using System.Text;

namespace CorrecaoExercicioHP.Entities
{
    class Imovel
    {
        public string Endereco { get; set; }
        public double Valor { get; set; }

        public Imovel()
        {
        }

        public Imovel(string endereco, double valor )
        {
            Endereco = endereco;
            Valor = valor;
        }

        public virtual void CalcularValor(double preco, double metroQuadrado)
        {
            Valor = preco * metroQuadrado;
        }

        public override string ToString()
        {
            return "Endereço da casa: " + Endereco
                + "Valor: " + Valor.ToString("C2");
        }

    }
}
