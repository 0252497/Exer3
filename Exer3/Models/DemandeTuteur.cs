using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exer3.Models
{
    public class DemandeTuteur
    {
        [StringLength(50, ErrorMessage = "Le prénom ne doit pas excéder 50 caractères")]
        [Required(ErrorMessage = "Le prénom de l'étudiant est requis")]
        public string Prenom { get; set; }

        [StringLength(50, ErrorMessage = "Le nom ne doit pas excéder 50 caractères")]
        [Required(ErrorMessage = "Le nom de l'étudiant est requis")]
        public string Nom { get; set; }

        [StringLength(10, ErrorMessage = "Le DA ne doit pas excéder 10 caractères")]
        [Required(ErrorMessage = "Le numéro de DA de l'étudiant est requis")]
        public string NumeroDA { get; set; }

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
            ErrorMessage = "Le format de l'adresse courriel est invalide")]
        [Required(ErrorMessage = "Le courriel de l'étudiant est requis")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "Le cours est requis")]
        public string Cours { get; set; }
    }
}
