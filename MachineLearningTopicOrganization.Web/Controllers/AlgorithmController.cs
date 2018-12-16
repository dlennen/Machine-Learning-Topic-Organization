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
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new AlgorithmService(userId);
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
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new AlgorithmService(userId);
            
             service.CreateAlgorithm(model);
            
             return RedirectToAction("Index");

        }
    }
}