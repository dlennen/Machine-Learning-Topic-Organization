using MLTO.Models;
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
            var model = new AlgorithmListItem[0];
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
            if (ModelState.IsValid)
            {
                
            }
            return View(model);
        }
    }
}