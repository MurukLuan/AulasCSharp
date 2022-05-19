using System;
using CorrecaoExercicioHP.Entities;

namespace CorrecaoExercicioHP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Imovel im1 = new ImovelNovo();
            Imovel im2 = new ImovelVelho();

            double valorMetro;
            double metrosQ;

            Console.WriteLine("Qual o tipo de imovel deseja: (1 = novo, 2 = Rustico) ");
            int opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1 :
                    Console.WriteLine("Entre com o endereço do imovel: ");
                    im1.Endereco = Console.ReadLine();
                    Console.WriteLine("Entre com o valor do metro quadrado: ");
                    valorMetro = double.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com quantos metros quadrados: ");
                    metrosQ = double.Parse(Console.ReadLine());
                    im1.CalcularValor(valorMetro, metrosQ);
                    Console.WriteLine(im1);
                    break;

                    //197 mts
                    //10209.00

                case 2 :
                    Console.WriteLine("Entre com o endereço do imovel: ");
                    im2.Endereco = Console.ReadLine();
                    Console.WriteLine("Entre com o valor do metro quadrado: ");
                    valorMetro = double.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com quantos metros quadrados: ");
                    metrosQ = double.Parse(Console.ReadLine());
                    im2.CalcularValor(valorMetro, metrosQ);
                    Console.WriteLine(im2);
                    break;

                default :
                    Console.WriteLine("Valor inserido invalido! Entre com um valor valido!");
                    break;
            }*/

            /*Console.WriteLine("Entre com a sua data de nascimento: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            DateTime ano = DateTime.Now;

            Console.WriteLine(ano.Year - dataNascimento.Year);*/

            DateTime entrada = new DateTime(2022, 05, 18, 19, 00, 00);
            DateTime saida = new DateTime(2022, 05, 18, 19, 45, 00);

            TimeSpan tempoPermanencia = saida.Subtract(entrada);
            Console.WriteLine("Seu tempo de permanencia  no estacionamento: " + tempoPermanencia);
            double valorCobrado = tempoPermanencia.TotalMinutes * 0.10;
            Console.WriteLine("Valor a ser cobrado: " + valorCobrado.ToString("C2"));

        }
    }
}
