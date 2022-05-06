
namespace IntroducaoConstrutores
{
    class Produtos
    {

        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public Produtos()
        {
        }

        public Produtos(int quantidade)
        {
            Quantidade = quantidade;
        }

        public Produtos(string nome, double preco, int quantidade) : this(quantidade)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \npreço: {Preco:F2} \nquantidade: {Quantidade}";
        }
    }
}
