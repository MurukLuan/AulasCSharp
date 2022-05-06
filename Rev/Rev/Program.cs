using System;

namespace Rev
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros [i, j] = i;
                Console.Write(i);
                for (int j = 0; j < numeros.Length; j++)
                {
                   Console.Write(j);                     
                }
                
            }
        }
    }
}
