using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bibliotheque.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        [EmailAddress]
        public string AdresseMail { get; set; }

        [Required]
        [Phone]
        public string NumeroTelephone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string MotDePasse { get; set; }
    }
}