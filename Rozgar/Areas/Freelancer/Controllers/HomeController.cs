using Dapper;
using Microsoft.AspNet.Identity;
using Rozgar.Entities;
using Rozgar.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rozgar.Areas.Freelancer.Controllers
{
    public class HomeController : Controller
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string currentUser = System.Web.HttpContext.Current.User.Identity.GetUserId();
        // GET: Freelancer/Home
        public ActionResult Feed()
        {
            var modelList = new List<Job>();
            using (var db = new SqlConnection(connectionString))
            {
                modelList = db.Query<Job>("Select * From Jobs Where Id " +
                    "In (Select JobId From JobSkills where SkillId " +
                    "In (Select SkillId From UserSkills where FreelancerId = '" + currentUser +"'))").ToList();
            }
            return View(modelList);
        }
        public ActionResult Details(int? id)
        {
            if (id.Equals(null))
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var job = new Job();
            var skills = new List<Skill>();
            using (var db = new SqlConnection(connectionString))
            {
                job = db.Query<Job>("Select * From Jobs Where Id =" + id, new { id }).FirstOrDefault();
                skills = db.Query<Skill>("Select * From Skills s where exists " +
                    "(Select SkillId from JobSkills jb where s.Id = jb.SkillId AND jb.JobId =" + id + ")", new { id }).ToList();
            }
            if (job.Equals(null))
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            var model = new JobDetailViewModel();
            model.Job = job;
            foreach (var item in skills)
            {
                model.Skills.Add(item.Name);
            }
            return View(model);
        }
    }
}