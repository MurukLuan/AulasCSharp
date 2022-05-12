using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoOO
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        public string Telefone { get; private set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public Pessoa(string nome, int idade, double altura, string telefone) : this(nome, idade, altura)
        {
            Telefone = telefone;
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                    + "\nIdade: " + Idade
                    + "\nAltura: " + Altura
                    + "\nTelefone: " + Telefone;
        }
    }
}
