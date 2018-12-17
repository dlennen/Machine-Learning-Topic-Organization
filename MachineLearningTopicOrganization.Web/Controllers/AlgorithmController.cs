using Microsoft.AspNet.Identity;
using MLTO.Models;
using MLTO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MachineLearningTopicOrganization.Web.Controllers
{
    [Authorize]
    public class AlgorithmController : Controller
    {
        // GET: Algorithm
        public ActionResult Index()
        {
            var service = CreateAlgorithmService();
            var model = service.GetAlgorithms();

            return View(model);
        }

        // GET Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlgorithmCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateAlgorithmService();

            if (service.CreateAlgorithm(model))
            {
                TempData["SaveResult"] = "Your note was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Note could not be created.");

            return View(model);

        }

        public ActionResult Details(int id)
        {
            var svc = CreateAlgorithmService();
            var model = svc.GetAlgorithmById(id);

            return View(model);
        }

        private AlgorithmService CreateAlgorithmService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new AlgorithmService(userId);
            return service;
        }
    }
}