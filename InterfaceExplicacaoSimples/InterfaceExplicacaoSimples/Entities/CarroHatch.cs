using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExplicacaoSimples.Entities
{
    class CarroHatch : Carro
    {
        public CarroHatch()
        {
            Tipo = "Hatch";
            Marca = "Chevrolet";
            Modelo = "Onix";
        }

        public override void PrepaparParaTransporte()
        {
            Console.WriteLine($"O carro {Marca} - {Modelo} tipo {Tipo} esta sendo preparado!");
        }

        public override void Transportar()
        {
            Console.WriteLine($"O carro ({Tipo}, {Modelo}) ja esta sendo tranportado, tempo estimado 5 dias");
        }
        public override void Entregar()
        {
            Console.WriteLine("Carro entregue na concessionaria plano piloto");
            Console.WriteLine($"Detalhes do carro: \ntipo: {Tipo} \nModelo: {Modelo}\nModelo:{Marca}");
        }
    }
}
