using System.ComponentModel.DataAnnotations;

namespace TestarCrudEF.Models
{
    public class Produto
    {
        [Key()]
        public int Id { get; set; }
        public string Descricao { get; set; }

        public double valor { get; set; }
        public int Quantidade { get; set; }
    }
}
