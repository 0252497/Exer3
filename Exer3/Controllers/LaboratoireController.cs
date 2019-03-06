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
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult RapportIncident()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RapportIncident(RapportIncident incident)
        {
            CreerDemande(incident);
            return RedirectToAction("Index");
        }

        public void CreerDemande(RapportIncident incident)
        {
            List<RapportIncident> incidents = HttpContext.Session.Get<List<RapportIncident>>("RapportIncident");
            incidents.Add(incident);
            HttpContext.Session.Set("RapportIncident", incidents);
        }
    }
}