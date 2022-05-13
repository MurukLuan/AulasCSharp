using System;
using System.Collections.Generic;
using System.Text;

namespace AulaRevisao_13_05_2022
{
    class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; protected set; }
        public int Agencia { get; set; }

        public Enum Status { get; set; }

        public Conta()
        {

        }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, int agencia) : this(numero, nome)
        {
            Agencia = agencia;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
