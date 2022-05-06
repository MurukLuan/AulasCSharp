using System;

namespace CalcularAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularArea tr1, tr2;
            tr1 = new CalcularArea();
            tr2 = new CalcularArea();

            Console.WriteLine("Digite os lados do triangulo: ");
            tr1.A = double.Parse(Console.ReadLine());
            tr1.B = double.Parse(Console.ReadLine());
            tr1.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os lados do triangulo 2: ");
            tr2.A = double.Parse(Console.ReadLine());
            tr2.B = double.Parse(Console.ReadLine());
            tr2.C = double.Parse(Console.ReadLine());

            double areaA = tr1.Triangulo();

            double areaB = tr2.Triangulo();



            if(areaA > areaB)
            {
                Console.WriteLine("Triangulo a tem a maior area: " + (areaA).ToString("F2"));
            }
            else
            {
                Console.WriteLine("Triangulo a tem a maior area: " + (areaB).ToString("F2"));
            }
        }
    }
}
