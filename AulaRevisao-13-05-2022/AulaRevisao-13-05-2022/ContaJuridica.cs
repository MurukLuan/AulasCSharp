namespace AulaRevisao_13_05_2022
{
    class ContaJuridica : Conta
    {
        public double Emprestimo { get; set; }

        public ContaJuridica(int numero, string nome, int agencia, double emprestimo) : base(numero, nome, agencia)
        {
            Emprestimo = emprestimo;
        }

        public void Emprestimos(double valor)
        {
            Saldo += valor;
        }

        
    }
}
