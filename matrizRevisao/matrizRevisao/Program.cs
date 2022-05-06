using System;

namespace matrizRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ , ] numeros = new int[4, 4];
            int contador = 10;
            int[ , ] valor = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                //Console.WriteLine("Linha: " + i);
                for (int j = 0; j < 4; j++)
                {
                    contador += 1;
                    //Console.WriteLine("\tcoluna:" + j);                    
                    Console.Write(" "+ contador + "\t");
                    valor[i, j] = contador;
                    
                }
                Console.WriteLine();
                
            }

            Console.WriteLine("Valores na diagonal: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(valor[i, i] + " ");
            }
            
        }
    }
}
