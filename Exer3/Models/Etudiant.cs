using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exer3.Models
{
    public class Etudiant
    {
        [Required(ErrorMessage = "L'id de l'étudiant est requis")]
        public int EtudiantID { get; set; }

        [Required(ErrorMessage = "Le prénom de l'étudiant est requis")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Le nom de l'étudiant est requis")]
        public string Nom { get; set; }
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Veuillez saisir une adresse courriel valide")]
        public string Courriel { get; set; }
        public string Matricule { get; set; }
        public string Programme { get; set; }
        public string Telephone { get; set; }
    }
}
