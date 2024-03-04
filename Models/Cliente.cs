using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Validatori.Models
{
    public class Cliente
    {
        [Key]
        public int Cliente_ID { get; set; }


        [Display(Name = "Azienda")]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public bool Azienda { get; set; }


        [Display(Name = "Codice Fiscale")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Il codice fiscale deve avere 16 caratteri")]
        public string Cod_Fisc { get; set; }


        [Display(Name = "Partita Iva")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "La Partita Iva deve avere 11 numeri")]
        public string PI { get; set; }


        [Required(ErrorMessage = "Campo obbligatorio")]
        [Display(Name = "Email")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "L'email deve contenere almeno 3 caratteri")]
        public string Email { get; set; }

        
        [Display(Name = "Telefono/Cellulare")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Il telefono deve avere almeno 7 numeri")]
        public string Tel { get; set; }


        [Required(ErrorMessage = "Campo obbligatorio")] 
        [Display(Name = "Nome")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Il nome deve contenere almeno 1 carattere")]
        public string Nome { get; set; }


        [Display(Name = "Cognome")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Il cognome deve contenere almeno 1 carattere")]
        public string Cognome { get; set; } 





    }
}