using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Albergo.Models
{
    public class Pensione
    {
        [Key]
        public int Pensione_ID { get; set; }


        [Required(ErrorMessage = "Campo Tipo Pensione Obbligatorio")]
        [Display(Name = "Tipo Pensione")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il Tipo Pensione deve avere massimo 50 caratteri")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Campo Supplemento Obbligatorio")]
        [Range(1, 1000000, ErrorMessage = "Max 1000000, min 10 cifre")]
        public decimal Supplemento { get; set; }
    }
}