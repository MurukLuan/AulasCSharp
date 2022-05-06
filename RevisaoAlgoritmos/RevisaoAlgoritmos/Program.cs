using System;
using System.Globalization;

namespace RevisaoAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {

            Teste calc = new Teste();

            Console.WriteLine("Entre com o primeiro numero: ");
            calc.N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo numero: ");
            calc.N2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o operador (soma, sub...): ");
            calc.Operador = Console.ReadLine();

            Console.WriteLine(calc.Calcular());

            /*Teste p1, p2;
            p1 = new Teste();
            p2 = new Teste();

            Console.WriteLine("Entre com o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Entre com o peso da primeira pessoa: ");
            p1.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a altura da primeira pessoa: ");
            p1.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Entre com o peso da segunda pessoa: ");
            p2.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a altura da segunda pessoa: ");
            p2.Altura = double.Parse(Console.ReadLine());
            */

           /* double calculaF = 0.0;
            double calculaC = 0.0;

            Console.WriteLine("Insira o tipo de temperatura a ser calculada");
            string tipoT = Console.ReadLine();

            Console.WriteLine("Insira a temperatura a ser calculada");
            double ValorT = double.Parse(Console.ReadLine());

            if (tipoT == "F" || tipoT == "f")
            {
                Console.WriteLine(calculaF = ConversaoF(ValorT));
            }
            else if (tipoT == "c" || tipoT == "C")
            {
                Console.WriteLine(calculaC = ConversaoC(ValorT));
            }
            else
            {
                Console.WriteLine("Tipo de temperatura invalida!!");
            }*/

            
        }

        /*static double ConversaoF(double T)
        {
            return ((T - 32) * 5 / 9);
        }
        static double ConversaoC(double T)
        {
            return ((T * 9/5) + 32);
        }*/


        

        

    }
}
