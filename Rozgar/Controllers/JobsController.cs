using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rozgar.Entities;
using Rozgar.Models;

namespace Rozgar.Controllers
{
    public class JobsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Jobs
        public ActionResult Post()
        {
            ViewBag.SubCategoryId = new SelectList(db.SubCategories.Where(p => p.Status == true),"Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Post(Job model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}