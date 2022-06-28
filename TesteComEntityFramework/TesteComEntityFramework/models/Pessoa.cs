using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using TesteComEntityFramework.repository;

namespace TesteComEntityFramework.models
{
    public class Pessoa
    {
        [Key()]
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }



        public void Salvar()
        {
            var db = new BancoContexto();
            db.Pessoas.Add(this);
            db.SaveChanges();
        }

        public List<Pessoa> RetornarTodos()
        {
            var db = new BancoContexto();
            return db.Pessoas.ToList();
        }
    }
}
