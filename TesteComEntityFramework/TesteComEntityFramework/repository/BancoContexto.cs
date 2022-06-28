using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

using TesteComEntityFramework.models;

namespace TesteComEntityFramework.repository
{
    public class BancoContexto : DbContext
    {
        public BancoContexto() : base("BancoTeste"){ }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
