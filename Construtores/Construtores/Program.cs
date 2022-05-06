using System;

namespace Construtores
{
    class Program
    {
        
        static void Main(string[] args)
        {


            
            Calculadores calc = new Calculadores() {A = 10, C = 90 };

            Console.WriteLine( calc.Somar());
            Console.WriteLine(calc.Somar2(1.5 , 2));
        }
    }
}
