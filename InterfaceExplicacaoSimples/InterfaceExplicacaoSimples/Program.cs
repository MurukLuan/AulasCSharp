using InterfaceExplicacaoSimples.Entities;
using System;

namespace InterfaceExplicacaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("****** Concessionaria PLano Piloto*******");
            Console.Write("Entre com H para hatch e S para sedan!");

            var carroTipoEscolhido = Console.ReadLine().ToUpper();

            try
            {
                Carro carro = CriarCarroSimpleFactory.CriarCarro(carroTipoEscolhido.ToUpper());
                carro.PrepaparParaTransporte();
                carro.Transportar();
                carro.Entregar();
            }
            catch(Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
            Console.WriteLine();
            
        }
    }
}
