using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Albergo.Models
{
    public class Ospite
    {
        [Key]
        public int Ospite_ID { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il Nome deve avere massimo 50 caratteri")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il Cognome deve avere massimo 50 caratteri")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La Città deve avere massimo 50 caratteri")]
        public string Citta { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La Provincia deve avere massimo 50 caratteri")]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Email Campo Obbligatorio")]
        [Display(Name = "E-mail")]
        [StringLength(255, ErrorMessage = "L'email deve avere massimo 255 caratteri")]
        [RegularExpression(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$", ErrorMessage = "Inserisci un indirizzo email valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Telefono Obbligatorio")]
        [Display(Name = "Telefono/Cellulare")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Minimo 7 cifre, massimo 20")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Il campo Tel accetta solo numeri.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Campo Codice Fiscale Obbligatorio")]
        [Display(Name = "Codice Fiscale")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Il codice fiscale deve avere 16 caratteri")]
        public string Cod_Fisc { get; set; }

        public string NomeCompletoCodFisc
        {
            get { return $"{Nome} {Cognome} - {Cod_Fisc}"; }
        }
    }
}