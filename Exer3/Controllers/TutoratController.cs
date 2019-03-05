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
    public class TutoratController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult DemandeTuteur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DemandeTuteur(DemandeTuteur etudiant)
        {
            CreerDemande(etudiant);
            return RedirectToAction("Index");
        }

        public void CreerDemande(DemandeTuteur etudiant)
        {
            List<DemandeTuteur> etudiants = HttpContext.Session.Get<List<DemandeTuteur>>("Etudiants");
            etudiants.Add(etudiant);
            HttpContext.Session.Set("Etudiants", etudiants);
        }

        public ActionResult OffrirTuteur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OffrirTuteur(OffreTuteur etudiant)
        {
            AjoutTuteur(etudiant);
            return RedirectToAction("Index");
        }

        public void AjoutTuteur(OffreTuteur etudiant)
        {
            List<OffreTuteur> etudiants = HttpContext.Session.Get<List<OffreTuteur>>("Etudiants");
            etudiants.Add(etudiant);
            HttpContext.Session.Set("Etudiants", etudiants);
        }
       
    }
}