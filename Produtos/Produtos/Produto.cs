using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos
{
    class Produto
    {
        public int Identificador;
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Quantidade * Preco;
        }

        public int AdicionarProduto(int qtd)
        {
            return Quantidade = Quantidade + qtd;
        }

        public int RemoverProduto(int qtd)
        {
            return Quantidade = Quantidade - qtd;
        }

        public override string ToString()
        {
            return "Id: " + Identificador
                   + ", Nome: " + Nome
                   + ", Preço: " + Preco
                   + ", Quantidade: " + Quantidade
                   + ", Valor total em estoque: " + ValorTotalEstoque();
        }
    }
}
