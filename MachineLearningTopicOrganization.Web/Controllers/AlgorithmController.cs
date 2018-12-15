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
    }
}