namespace IntoduçãoHerança
{
    class Conta
    {

        public int NumeroConta { get; set; }
        public double Saldo { get;  protected set; }
        public string Nome { get; set; }

        public Conta()
        {

        }

        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
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
