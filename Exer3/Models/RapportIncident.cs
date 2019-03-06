using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exer3.Models
{
    public class RapportIncident
    {
        [StringLength(50, ErrorMessage = "Le prénom ne doit pas excéder 50 caractères")]
        [Required(ErrorMessage = "Le prénom est requis")]
        public string Prenom { get; set; }

        [StringLength(50, ErrorMessage = "Le nom ne doit pas excéder 50 caractères")]
        [Required(ErrorMessage = "Le nom est requis")]
        public string Nom { get; set; }

        [StringLength(10, ErrorMessage = "L'identifiant ne doit pas excéder 10 caractères")]
        [Required(ErrorMessage = "L'identifiant est requis")]
        public string Identifiant { get; set; }

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
        ErrorMessage = "Le format de l'adresse courriel est invalide")]
        [Required(ErrorMessage = "Le courriel de l'étudiant est requis")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "Veuillez entrer votre incident")]
        public TypeProblème Probleme { get; set; }

        [Required(ErrorMessage = "Veuillez entrer la plateforme où le problème est recontré")]
        public Plateforme PlateformeErreur { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une description du problème rencontré")]
        public string DescriptionComportement { get; set; }
    }

    public enum TypeProblème
    {
        MessageErreur,
        ProblemeConnexion,
        OubliMotDePasse,
        Autre
    }

    public enum Plateforme
    {
        Outlook,
        Excel,
        Word,
        Powerpoint,
        VisualStudio,
        Omnivox,
        Windows,
        Autre
    }
}
