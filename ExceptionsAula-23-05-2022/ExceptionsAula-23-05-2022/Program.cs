using System;
using ExceptionsAula_23_05_2022.Entities;
using ExceptionsAula_23_05_2022.Entities.Exceptions;

namespace ExceptionsAula_23_05_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            /*try
            {
                Console.WriteLine("Entre com o primeiro numero: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o primeiro numero: ");
                int n2 = int.Parse(Console.ReadLine());

                double resultado = n1 / n2;
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("O segundo numero não pode ser zero! " + e.Message);
            }catch (FormatException e)
            {
                Console.WriteLine("O dado tem que ser numerico, vc digitou uma letra!" + e.Message);
            }*/
            try
            {
                Console.Write("Entre com o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Entre com a quantidade do produto: ");
                int qtd = int.Parse(Console.ReadLine());

                Console.Write("Entre com o valor do produto: ");
                double valor = double.Parse(Console.ReadLine());

                Produto prod = new Produto(nome, qtd, valor);
                prod.VerificarErro(nome);
                prod.VerificarErro(qtd);

                Console.WriteLine(prod);
            }catch(ExcecaoProduto e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            

            
        }
    }
}
