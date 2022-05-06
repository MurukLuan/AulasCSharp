using System;

namespace Atividades_13_04
{
    class Program
    {
        /*static void Main(string[] args)
        { 
            
            string original = "Luan Muruk curso c#";

            
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            string[] s8 = original.Split(' ');
            

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            /*
            for (int i = 0; i < s8.Length; i++)
            {
                Console.WriteLine(s8[i]);
            }
            
            /*var nome = "Luan";
            var numero = 10;
            var real = 10.56;
            var boleano = true;

            Console.WriteLine(nome + numero + real + boleano);
            Console.WriteLine(nome.GetType());
            Console.WriteLine( numero.GetType());
            Console.WriteLine(real.GetType());
            Console.WriteLine( boleano.GetType());*/

        /* Console.WriteLine("Entre com o dia: ");
         int dia = int.Parse(Console.ReadLine());
         int x = 3;

         switch (dia)
         {
             case 1:
                 Console.WriteLine("Domingo");
                 break;
             case 2:
                 Console.WriteLine("Segunda");
                 break;
             default:
                 Console.WriteLine("Comando errado!");
                 break;

         }*/

        /*
        string resultado = (2 < 5) ? "verdadeiro" : "falso";
        Console.WriteLine(resultado);
        */
        /*
        Console.WriteLine("Entre com a quantidade de litros abastecida:");
        double litro = double.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o tipo de combustivel: ");
        char combustivel = char.Parse(Console.ReadLine());

        double prePagar = 0.0;

        if(combustivel == 'a')
        {
            if(litro <= 20)
            {
                for(int i = 0; i < litro; i++)
                {
                    prePagar = prePagar * 5.12;
                    prePagar = prePagar - (prePagar - 0.03);
                }
                prePagar = (litro * 5.12);
                prePagar = prePagar - (prePagar * 0.03);
            }
            else
            {
                prePagar = litro * 5.12;
                prePagar = prePagar - (prePagar * 0.05);

            }
        }
        else
        {
            if(litro <= 20)
            {
                prePagar = litro * 7.69;
                prePagar = prePagar - (prePagar * 0.04);
            }
            else
            {
                prePagar = litro * 7.69;
                prePagar = prePagar - (prePagar * 0.06);
            }
        }

        Console.WriteLine("Valor a ser pago: " + prePagar);

        */

        /*Random dado = new Random();

        int rolagem1 = dado.Next(1 , 7);
        Console.WriteLine("O numero foi: " + rolagem1);*/

        
            
    }
}
