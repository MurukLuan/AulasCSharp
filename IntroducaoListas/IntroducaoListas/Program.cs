using System;
using System.Collections.Generic;

namespace IntroducaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Rodrigo");
            nomes.Add("João");
            nomes.Add("Rosa");
            nomes.Add("Marcia");
            nomes.Add("Gustavo");

            nomes.Insert(5, "Ricardo");
            nomes.Insert(0, "Ana");

            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Quantidade de itens na lista: " + nomes.Count);

            Console.WriteLine("Primeiro elemento com a letra inicial R: " + nomes.Find(x => x[0] == 'R'));
            Console.WriteLine("Ultimo elemento com a letra inicial R: " + nomes.FindLast(x => x[0] == 'R'));

            Console.WriteLine("Primeira posição do elemento com a letra inicial R: " + nomes.FindIndex(x => x[0] == 'R'));
            Console.WriteLine("Primeira posição do elemento com a letra inicial R: " + nomes.FindLast(x => x[0] == 'R'));

            List<string> nomes2 = nomes.FindAll(x => x[0] == 'R');

            Console.WriteLine("Lista 2: ");
            foreach(string obj in nomes2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Itens removidos: \n\n\n\n");

            //nomes.Remove("João");
            //nomes.RemoveAll(x => x[0] == 'R');
            //nomes.RemoveAt(6);
            nomes.RemoveRange(2, 2);

            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
