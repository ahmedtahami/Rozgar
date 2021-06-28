using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using Microsoft.AspNet.Identity;
using Rozgar.Entities;
using Rozgar.Models;

namespace Rozgar.Controllers
{
    public class JobsController : Controller
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string currentUser = System.Web.HttpContext.Current.User.Identity.GetUserId();
        // GET: Jobs
        public ActionResult Post()
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            using (var db = new SqlConnection(connectionString))
            {
                subCategories = db.Query<SubCategory>("Select * from SubCategory Where Status = true").ToList();
            }
            ViewBag.SubCategoryId = new SelectList(subCategories, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Post(Job model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new SqlConnection(connectionString))
                {
                    db.Execute("INSERT INTO Jobs (Title,Description,Created,LastModified,Budget,ClientId,SubCategoryId,ExperienceLevel)" +
                       "Values (" + model.Title + "," + model.Description + "," + DateTime.Now + "," + DateTime.Now + "," + model.Budget + "," 
                       + currentUser + "," + model.SubCategoryId + "," + model.ExperienceLevel + ")");
                }
                return RedirectToAction("MyJobs");

            }
            return View(model);
        }
        public ActionResult MyJobs()
        {
            var modelList = new List<Job>();
            using (var db = new SqlConnection(connectionString))
            {
                modelList = db.Query<Job>("Select * from Jobs Where ClientId = " + currentUser).ToList();
            }
            return View(modelList);
        }
    }
}