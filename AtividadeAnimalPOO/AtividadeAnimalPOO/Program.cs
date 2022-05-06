using System;

namespace AtividadeAnimalPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.Write("Entre com o nome do animal: ");
            animal.Nome = Console.ReadLine();

            Console.Write("Entre com a especie do animal: ");
            animal.Especie = Console.ReadLine();

            Console.Write("Entre a quantidade de patas: ");
            animal.QtdPatas = int.Parse(Console.ReadLine());

            Console.Write("Nome do animal: " + animal.Nome
                         +"\nEspecie: " + animal.Especie
                         +"\nQuantidade de patas: " + animal.QtdPatas);
        }
    }
}
