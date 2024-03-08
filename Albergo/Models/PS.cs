using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Albergo.Models
{
    public class PS
    {
        public int Prenotazione_ID { get; set; }

        public int Servizio_ID { get; set; }

        public Prenotazione Prenotazione { get; set; }
        public Servizio Servizio { get; set; }

        [Required(ErrorMessage = "Campo Data Obbligatorio")]
        [Display(Name = "Data")]
        public DateTime Data_Serv { get; set; }

        [Required(ErrorMessage = "Campo Quantità Obbligatorio")]
        public int Quantita { get; set; }

        [Required(ErrorMessage = "Campo Prezzo Servizi Obbligatorio")]
        [Display(Name = "Prezzo Servizio")]
        [Range(1, 1000000, ErrorMessage = "Max 1000000, min 10 cifre")]
        public decimal PrezzoServ { get; set; }
    }
}