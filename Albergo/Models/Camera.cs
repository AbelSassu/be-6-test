using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Albergo.Models
{
    public class Camera
    {
        [Key]
        public int Camera_ID { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(255, ErrorMessage = "La descrizione deve avere massimo 255 caratteri")]
        public string Descrizione { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        public int Categoria_ID { get; set; }

        [Required(ErrorMessage = "Campo Obbligatorio")]
        public Categoria Categoria  {get; set;}
    }
}