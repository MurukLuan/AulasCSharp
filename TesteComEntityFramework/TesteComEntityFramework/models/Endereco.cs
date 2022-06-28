using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TesteComEntityFramework.repository;

namespace TesteComEntityFramework.models
{
    public class Endereco
    {
        [Key()]
        public int IdEndereco { get; set; }
        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; } //campo que faz referencia a tabela pessoa
        public string EnderecoCompleto { get; set; }

        public void Salvar()
        {
            var db = new BancoContexto();
            db.Enderecos.Add(this);
            db.SaveChanges();
        }

        public List<Endereco> RetornarTodos()
        {
            var db = new BancoContexto();
            return db.Enderecos.ToList();
        }
    }
}
