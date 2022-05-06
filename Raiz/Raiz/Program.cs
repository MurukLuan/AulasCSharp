using System;

namespace Raiz
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularRaiz calc = new CalcularRaiz();
            

            Console.WriteLine("Entre com os valor de a, b, c: ");
            calc.A = double.Parse(Console.ReadLine());
            calc.B = double.Parse(Console.ReadLine());
            calc.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Delta: " + calc.Delta());
            Console.WriteLine("X1: " + calc.X1());
            Console.WriteLine("X2: " + calc.X2());

        }
    }
}
