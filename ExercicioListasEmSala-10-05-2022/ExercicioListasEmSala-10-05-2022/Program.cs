using System;
using System.Collections.Generic;

namespace ExercicioListasEmSala_10_05_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            
            List<Funcionario> func = new List<Funcionario>();
            do
            {
                Console.Write("Entre com o nome do funcionario: ");
                string nome = Console.ReadLine();

                Console.Write("Entre com o salario do funcionario: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Entre com a idade do funcionario: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Entre com o e-mail do funcionario: ");
                string email = Console.ReadLine();

                Console.Write("Entre com o departamento do funcionario: ");
                string departamento = Console.ReadLine();
                departamento.ToLower();

                func.Add(new Funcionario(nome, salario, idade, email, departamento));

                Console.Write("Deseja cadastrar mais um funcionario? (s/n)");
                opcao = char.Parse(Console.ReadLine());
                

            } while (opcao == 's');

            Console.WriteLine("-----------------------------------------------");

            foreach (Funcionario obj in func)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Quantidade de trabalhadores: " + func.Count);

            int contador = 0;
            if (func.Exists(x => x.Departamento == "rh"))
            {
                foreach(Funcionario obj in func)
                {         
                    if(obj.Departamento == "rh")
                    {
                        contador++;
                    }
                    
                }
                Console.WriteLine(contador);
            }
            




        }
    }
}
