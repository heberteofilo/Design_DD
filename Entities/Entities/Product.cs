using Entities.Notiications;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class Product : Notifies
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

    }
}
