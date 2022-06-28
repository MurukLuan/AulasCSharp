using System.ComponentModel.DataAnnotations;

namespace CrudEF.Models
{
    public class Aluno
    {
        [Key()]
        public int AlunoId { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(50)]
        public string Email { get; set; }


    }
}
