using System;

namespace AtividadeCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calc = new Calcular();

            Console.WriteLine("Entre com dois numeros e depois com o operador: ");
            calc.N1 = double.Parse(Console.ReadLine());
            calc.N2 = double.Parse(Console.ReadLine());
            calc.Operador = Console.ReadLine();

            Console.WriteLine(calc);
        }
    }
}
