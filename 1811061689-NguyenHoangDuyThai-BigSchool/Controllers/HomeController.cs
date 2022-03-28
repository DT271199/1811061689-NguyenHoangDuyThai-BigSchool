﻿using _1811061689_NguyenHoangDuyThai_BigSchool.Models;
using _1811061689_NguyenHoangDuyThai_BigSchool.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1811061689_NguyenHoangDuyThai_BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

       
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturee)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            var viewModel = new CourseViewModel
            {
                UpcommingCourse = upcommingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);     
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}