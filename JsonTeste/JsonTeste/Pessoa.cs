using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JsonTeste
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }

        public Pessoa()
        {
           
        }
        /*
        public override string ToString()
        {
            return Nome + " " + Telefone + " " + DataNascimento + " "
                + Endereco + " " + Cidade + " "
                + Uf + " " + Bairro + " " + Cep;
        }*/

    }
}
