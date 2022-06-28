using Microsoft.EntityFrameworkCore;

namespace CrudEF.Models
{
    public class ApplicationDataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CrudAluno; Integrated Security=True");
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
