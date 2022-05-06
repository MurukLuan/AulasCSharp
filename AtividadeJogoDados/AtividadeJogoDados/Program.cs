using System;

namespace AtividadeJogoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();

            int dado1 = dado.Next(1, 7);
            int dado2 = dado.Next(1, 7);
            int dado3 = dado.Next(1, 7);

            int total = dado1 + dado2 + dado3;

            Console.WriteLine("Dado1: " + dado1);
            Console.WriteLine("Dado2: " + dado2);
            Console.WriteLine("Dado3: " + dado3);


            if((dado1 == dado2) || (dado1 == dado3 )|| (dado2 == dado3))
            {
                
                if ((dado1 == dado2) && (dado2 == dado3))
                {
                    total = total + 3;
                    Console.WriteLine("Parabens, vc ganhou mais 3 pontos de bonus!");
                }
                else
                {
                    total = total + 2;
                    Console.WriteLine("Parabens, vc ganhou 2 pontos de bonus!");
                }
            }
            

            if(total >= 16)
            {
                Console.WriteLine("Parabens voce ganhou, total de pontos: "+ total);
            }
            else
            {
                Console.WriteLine("Infelizmente não foi dessa vez! total de pontos: "+ total);
            }

        }
    }
}
