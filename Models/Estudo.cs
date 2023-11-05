using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Link_Estudo.Models
{
    [Table("LinkEstudo")]
    public class Estudo
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Link")]
        [Column("Link")]
        public string? Link { get; set; }

        [Display(Name = "Assunto")]
        [Column("Assunto")]
        public string? Assunto { get; set; }

        [Display(Name = "Descrição")]
        [Column("Descrição")]
        public string? Descricao { get; set; }
    }
}
