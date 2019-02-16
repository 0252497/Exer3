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
    public class EtudiantController : Controller
    {
        // GET: Etudiant
        public ActionResult Index()
        {
            List<Etudiant> etudiant = HttpContext.Session.Get<List<Etudiant>>("Etudiants") ?? 
                PopulerListeEtudiants();
            return View(etudiant);
        }

        // GET: Etudiant/Details/5
        public ActionResult Details(int id)
        {
            Etudiant etudiant = RetrouverEtudiantParId(id);
            return View(etudiant);
        }

        // GET: Etudiant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Etudiant/Create
        [HttpPost]
        public ActionResult Create(Etudiant p_etudiant)
        {
            CreerEtudiant(p_etudiant);
            return RedirectToAction("Index");
        }

        // GET: Etudiant/Edit/5
        public ActionResult Edit(int id)
        {
            Etudiant etudiant = RetrouverEtudiantParId(id);
            return View(etudiant);
        }

        // POST: Etudiant/Edit/5
        [HttpPost]
        public ActionResult Edit(Etudiant p_etudiant)
        {
            ModifierEtudiant(p_etudiant);
            return RedirectToAction("Index");
        }

        // GET: Etudiant/Delete/5
        public ActionResult Delete(int id)
        {
            RetirerEtudiantParId(id);
            return RedirectToAction("Index");
        }

        public List<Etudiant> PopulerListeEtudiants()
        {
            List<Etudiant> etudiants = new List<Etudiant>();

            Etudiant etudiant1 = new Etudiant
            {
                EtudiantID = 1,
                Age = 18,
                Courriel = "shuot@gmail.com",
                Matricule = "12345",
                Nom = "Huot",
                Prenom = "Sébastien",
                Programme = "Informatique",
                Telephone = "(514)265-0987"
            };

            Etudiant etudiant2 = new Etudiant
            {
                EtudiantID = 2,
                Age = 22,
                Courriel = "jpoitras@gmail.com",
                Matricule = "123455",
                Nom = "Poitras",
                Prenom = "Jean",
                Programme = "Informatique",
                Telephone = "(514)265-0987"
            };

            Etudiant etudiant3 = new Etudiant
            {
                EtudiantID = 3,
                Age = 24,
                Courriel = "korn@gmail.com",
                Matricule = "1235",
                Nom = "Tremblay",
                Prenom = "Hugo",
                Programme = "Administration",
                Telephone = "(514)675-0987"
            };

            Etudiant etudiant4 = new Etudiant
            {
                EtudiantID = 4,
                Age = 18,
                Courriel = "paul@gmail.com",
                Matricule = "12322",
                Nom = "Joly",
                Prenom = "Paul",
                Programme = "Art",
                Telephone = "(514)265-0987"
            };

            etudiants.Add(etudiant1);
            etudiants.Add(etudiant2);
            etudiants.Add(etudiant3);
            etudiants.Add(etudiant4);

            HttpContext.Session.Set<List<Etudiant>>("Etudiants", etudiants);
            return etudiants;
        }

        public Etudiant RetrouverEtudiantParId(int ID)
        {
            List<Etudiant> etudiants = HttpContext.Session.Get<List<Etudiant>>("Etudiants");
            Etudiant etudiant = etudiants.Find(etud => etud.EtudiantID == ID);

            return etudiant;
        }

        public void RetirerEtudiantParId(int ID)
        {
            List<Etudiant> etudiants = HttpContext.Session.Get<List<Etudiant>>("Etudiants");
            etudiants.RemoveAll(etudiant => etudiant.EtudiantID == ID);

            HttpContext.Session.Set<List<Etudiant>>("Etudiants", etudiants);
        }

        public void CreerEtudiant(Etudiant p_etudiant)
        {
            List<Etudiant> etudiants = HttpContext.Session.Get<List<Etudiant>>("Etudiants") ?? PopulerListeEtudiants();
            etudiants.Add(p_etudiant);
            HttpContext.Session.Set<List<Etudiant>>("Etudiants", etudiants);
        }

        public void ModifierEtudiant(Etudiant p_etudiant)
        {
            List<Etudiant> etudiants = HttpContext.Session.Get<List<Etudiant>>("Etudiants") ?? PopulerListeEtudiants();
            int index = etudiants.FindIndex(et => et.EtudiantID == p_etudiant.EtudiantID);
            etudiants[index] = p_etudiant;

            HttpContext.Session.Set<List<Etudiant>>("Etudiants", etudiants);
        }
    }
}