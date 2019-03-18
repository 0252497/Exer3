using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Exer3.Models;
using Exer3.Extensions;

namespace Exer3.Controllers
{
    public class LaboratoireController : Controller
    {
        public ActionResult RapportIncident()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnvoyeMessage(RapportIncident p_rapportIncident)
        {
            string nomUtilisateur = p_rapportIncident.Nom;
            string identifiant = p_rapportIncident.Identifiant;
            string courriel = p_rapportIncident.Courriel;
            string typeProblèmes = p_rapportIncident.Probleme.ToString();
            string plateforme = p_rapportIncident.PlateformeErreur.ToString();
            string descriptionProblème = p_rapportIncident.DescriptionComportement;

            string body = string.Format(
                                    "Nom d'utilisateur: {0}" +
                                    "\nNuméro DA: {1}" +
                                    "\n\nType de problème: {2}" +
                                    "\nPlateforme causant l’erreur: {3}" +
                                    "\nDescription du problème: {4}",
                                    nomUtilisateur, identifiant, typeProblèmes, plateforme, descriptionProblème);

            Mail.MailHelper.EnvoyeMessage("Type de probleme", "nimporteQuoi", "giguere.vero@gmail.com");
            return RedirectToAction("Laboratoire/RapportIncident");
        }
    }
}