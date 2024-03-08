using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Albergo.Models
{
    public class Categoria
    {
        [Key]
        public int Categoria_ID { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Tipo Camera")]
        [StringLength(50, ErrorMessage = "La tipo deve avere massimo 50 caratteri")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Range(1, 1000000, ErrorMessage = "Max 100000 min 10 cifre")]

        public decimal TariffaNotte { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Range(1, 1000000, ErrorMessage = "Max 100000 min 10 cifre")]

        public decimal Caparra { get; set; }
    }
}