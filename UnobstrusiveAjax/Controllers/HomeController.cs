using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnobstrusiveAjax.Models;
using UnobstrusiveAjax.ViewModel;

namespace UnobstrusiveAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly IList<Individu> _individus;

        public HomeController()
        {
            _individus = new List<Individu>()
            {
                new Individu()
                {
                    FirstName = "Bastien",
                    LastName = "Boonen",
                    Nam = "BOOB12345678"
                },
                new Individu()
                {
                    FirstName = "Jane",
                    LastName = "Mary",
                    Nam = "JAMA87654321"
                }
            };
        }

        public ActionResult Index()
        {
            return View(new AjouterProjetViewModel());
        }

        [HttpPost]
        public JsonResult AjouterMembre(string nam)
        {
            if (!string.IsNullOrWhiteSpace(nam))
            {
                var individu = _individus.FirstOrDefault(x => x.Nam.Equals(nam));
                return Json(individu);
            }

            return null;
        }

        [HttpPost]
        public ActionResult AjouterProjet(List<ValidationMembreViewModel> model)
        {
            return PartialView("Index", model);
        }
    }
}