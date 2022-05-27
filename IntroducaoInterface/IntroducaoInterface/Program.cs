using IntroducaoInterface.Entities;
using IntroducaoInterface.Services;
using System;
using System.Globalization;

namespace IntroducaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do veiculo: ");
            Console.Write("Modelo:");

            string modelo = Console.ReadLine();
            Console.Write("Marca:");

            string marca = Console.ReadLine();
            Console.Write("Placa:");

            string placa = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Entre com a hora de entrada: (dd/MM/yyyy HH:mm)");
            DateTime entrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com a hora de saida: (dd/MM/yyyy HH:mm)");
            DateTime saida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Entre com o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine());

            Console.Write("Entre com o preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine());



            Estacionado est = new Estacionado(entrada, saida, new Carro(modelo, marca, placa));

            ServicoEstacionamento servico = new ServicoEstacionamento(precoHora, precoDia, new ImpostoEstacionamento());

            servico.processarPagamento(est);

            Console.WriteLine("fatura gerada para o tempo estacionado: ");
            Console.WriteLine(est.Fatura);
        }
    }
}
