using System;

namespace CodigoSExemploAula09_05_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*double? x = null;
            double? b = x ?? 10.45;

            Console.WriteLine(x);

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(b.Value);

            Console.WriteLine(Calculadora.Somar(1, 2, 3, 4, 5));*/


            int a = 5;
            int b;
            Calculadora.Dobrar(a, out b);
            Console.WriteLine(b);

        }
    }
}
