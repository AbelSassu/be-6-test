using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Albergo.Models
{
    public class Prenotazione
    {
        [Key]
        public int Prenotazione_ID { get; set; }

        [Required(ErrorMessage = "Campo Data Prenotazione Obbligatorio")]
        [Display(Name = "Data Prenotazione")]
        public DateTime Data_Pren { get; set; }

        [Required(ErrorMessage = "Campo Data Arrivo Obbligatorio")]
        [Display(Name = "Data Arrivo")]
        public DateTime Data_Arrivo { get; set; }

        [Required(ErrorMessage = "Campo Data Partenza  Obbligatorio")]
        [Display(Name = "Data Partenza")]
        public DateTime Data_Partenza { get; set; }

        public int AnnoProg { get; set; }

        public int Pensione_ID { get; set; }

        public int Ospite_ID { get; set; }

        public int Camera_ID { get; set; }

        public Pensione Pensione { get; set; }

        public Ospite Ospite { get; set; }

        public Camera Camera { get; set; }
    }
}