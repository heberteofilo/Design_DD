using Entities.Notiications;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class Product : Notifies
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome do produto deve ser preenchido.")]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preço do produto deve ser preenchido.")]
        [Display(Name = "Preço")]
        [Column("Preco", TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A quantidade do produto deve ser preenchida.")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

    }
}
