using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Albergo.Models
{
    public class Servizio
    {
        [Key]
        public int Servizio_ID { get; set; }

        [Required(ErrorMessage = "Campo Tipo Obbligatorio")]
        [Display(Name = "Tipo Servizio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il Tipo Servizio deve avere massimo 50 caratteri")]
        public string Tipo { get; set; }
    }
}