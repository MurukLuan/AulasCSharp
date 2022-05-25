using System;
using IntroducaoDelegates.Entities;
using System.Collections.Generic;
using System.Linq;

namespace IntroducaoDelegates
{

    //delegate int Delega(int n1, int n2);

    //delegate void Del();
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Calcular calc = new Calcular();

             //Delega delega = calc.Somar;
             Delega d = Calcular.Somar2;

             Console.WriteLine(d(10, 3));*/

            /*Del d = Calcular.Mensagem;
            d += Calcular.Mensagem2;
            d();*/
            Pessoa pessoa;

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa("LuaN", 32));
            pessoas.Add(new Pessoa("RoDrigo", 16));
            pessoas.Add(new Pessoa("RosA", 15));
            pessoas.Add(new Pessoa("MaRcia", 17));
            pessoas.Add(new Pessoa("VandeRson", 19));

            List<string> resultado = pessoas.Select(CaixaBaixa).ToList();

            foreach(string res in resultado)
            {
                Console.WriteLine(res);
            }

            //Action<Pessoa> act = AtualizarIdade;
            //pessoas.ForEach(AtualizarIdade);
            /*Action<Pessoa> act = p => { p.Idade += 3; };

            pessoas.ForEach(act);
            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p);
            }

            /*pessoas.RemoveAll(AtualizarIdade);

            foreach(Pessoa p in pessoas)
            {
                Console.WriteLine(p);
            }*/

        }
        static string CaixaBaixa(Pessoa p)
        {
            return p.Nome.ToLower();
        }

        /*public static bool AtualizarIdade(Pessoa p)
        {
            return p.Idade <= 18;
        }

        static void AtualizarIdade(Pessoa p)
        {
            p.Idade += 3;
        }*/
    }
}
