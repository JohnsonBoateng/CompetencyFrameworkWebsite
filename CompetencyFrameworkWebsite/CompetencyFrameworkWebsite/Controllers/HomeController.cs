﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompetencyFrameworkWebsite.Models;
using System.Configuration;
using System.Data.SqlClient;


namespace CompetencyFrameworkWebsite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ApiAccess apiAccess= new ApiAccess();
            var model = new TechnologyModel();
            model.Technologies = new List<string>();
            model.Technologies = apiAccess.GetAllTechnologies();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string technologies)
        {
            ApiAccess apiAccess = new ApiAccess();
            var model = new JobTitleModel();
            model.JobTitles = new List<string>();
            model.Technology = technologies;
            model.JobTitles = apiAccess.GetAllJobTitle(technologies);
          
            return View("JobTitleIndex",model);
         
        }

        //[HttpPost]
        //public ActionResult ResultsIndex (string technologies, string jobTitles)
        //{ 
        //   ApiAccess apiAccess = new ApiAccess();
        //   var model = new ResultsModel();
        //   model.Results = new List<Competency>();
        //   model.RatingID = new List<UserRatingData>();
        //   model.Results = apiAccess.GetAllResults(technologies,jobTitles);
           
        //   return View("ResultsIndex", model);
        //}
        
        //


        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}