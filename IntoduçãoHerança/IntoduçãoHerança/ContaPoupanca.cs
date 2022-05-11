
namespace IntoduçãoHerança
{
    class ContaPoupanca : Conta
    {
        public double Rendimento { get; set; }

        public ContaPoupanca(string nome, int numeroConta, double rendimento) : base(numeroConta, nome)
        {            
            Rendimento = rendimento;
        }

        public void Rendimentos(double valor){
            Saldo += valor;
        }

    }
}
