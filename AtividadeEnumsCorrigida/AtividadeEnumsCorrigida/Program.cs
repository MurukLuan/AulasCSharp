using AtividadeEnumsCorrigida.Entities;
using AtividadeEnumsCorrigida.Entities.Enums;
using System;

namespace AtividadeEnumsCorrigida
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Console.Write("Entre com o modelo do veiculo: ");
            carro.Modelo = Console.ReadLine();

            Console.Write("Entre com a marca do veiculo: ");
            carro.Marca = Console.ReadLine();

            Console.Write("Entre com a cor do veiculo: ");
            carro.Cor = Console.ReadLine();

            Console.Write("Entre com o ano do veiculo: ");
            carro.Ano = int.Parse(Console.ReadLine());

            Console.Write("Entre com o tipo de combustivel do veiculo: ");
            Console.Write("0 = Gasolina, 1 = Alcool, 2 = Hibrido, 3 = Eletrico ");
            int tipoComb = int.Parse(Console.ReadLine());
            carro.TipoComb(tipoComb);

            Console.Write("Entre com o tipo de cambio do veiculo: ");
            Console.Write("0 = Manual, 1 = Automatico, 2 = SemiAutomatico, 3 = Sequencial ");
            int tipoCamb = int.Parse(Console.ReadLine());
            carro.TipoCamb(tipoCamb);


            Console.WriteLine(carro);



        }
    }
}
