using System;
using System.Collections.Generic;

namespace AulaoRevisao2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();

            nomes.Add("Maria");
            nomes.Add("Joao");
            nomes.Add("Luan");
            nomes.Add("Rodrigo");
            nomes.Add("Rogerio");
            nomes.Add("Ricardo");

            nomes.Insert(3, "Cleber");

            


            foreach(string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(nomes.Count);

            Console.WriteLine(nomes.Find(x => x[0] == 'R'));
            Console.WriteLine(nomes.FindLast(X => X[0] == 'R'));

            Console.WriteLine(nomes.FindIndex(x => x[0] == 'R'));
            Console.WriteLine(nomes.FindLastIndex(x => x[0] == 'R'));

            List<string> nomes2 = nomes.FindAll(x => x.Length > 5);
            Console.WriteLine("Lista 2:");

            foreach(string obj in nomes2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\n\n\n");


            nomes.Remove("Luan");
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\n\n\nremover com R: ");
            nomes.RemoveAll(x => x[0] == 'R');
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\n\n\nremover na posição: ");
            nomes.RemoveAt(1);
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
