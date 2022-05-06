using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string nomeCompleto = "Luan Muruk";
            Console.WriteLine(nomeCompleto);

            //variaveis de tipo string (cadeias de caracteres) ficam entre aspas duplas
            nomeCompleto = "Maria";
            //Comando Console.WriteLine está imprimindo o conteido da variavel nomeCompleto
            Console.WriteLine(nomeCompleto);

            //variavel do tipo char fica envolto de aspas simples
            char sexo = 'F';
            //variaveis do tipo int (inteiro) armazenam numeros inteiros
            int idade = 11;
            //variaveis do tipo double armazenam numeros com pontos flutuantes
            double preco = 11.32;

            //o comando Console.WriteLine quebra uma linha no final da instrução
            Console.WriteLine("Aqui vai uma mensagem!!");
            //o comando Console.Write não quebra uma linha no final da instrução
            Console.Write("Aqui vai uma mensagem2!!");
            Console.Write("Aqui vai uma mensagem3!!");
            */

            /*string nome = "Luan Muruk";
            int idade = 31;
            double salario = 2307.00;

            Console.WriteLine("{0}, tem {1} anos, ganha R$ {2:F2}", nome, idade, salario);*/

            /*Console.WriteLine(Math.Min(1, 2));
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Round(25.956789, 2));
            Console.WriteLine(2 * Math.PI);
            */


            /* int numero = 0;
             double numero2 = 0.0;
             char letra;
             Console.Write("Entre com um numero inteiro: ");
             numero = int.Parse(Console.ReadLine());
             numero2 = double.Parse(Console.ReadLine());
             letra = char.Parse(Console.ReadLine());

             Console.WriteLine("Numero digitado: "+ numero);*/


            /*int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);*/

            /*int x = 0;

            Console.WriteLine("Entre com um numero: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine(x);*/

            /*Console.WriteLine(Math.Min(1, 2));
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Round(25.956789, 2));
            Console.WriteLine(2 * Math.PI);*/

            /*double numero = 14.4895;
            Console.WriteLine(numero.ToString("F3",CultureInfo.InvariantCulture));*/

            string x = "Bom dia";
            string y = "Boa tarde";
            string z = "Boa noite";
            double hora = 0;

            Console.WriteLine("Digite a hora atual: ");
            hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (hora > 0 && hora < 12)
            {
                Console.WriteLine(x);
            }
            else if (hora > 12 && hora < 18)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(z);
            }




        }
    }
}
