using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo01WebApp.Models;
using Demo01WebApp.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo01WebApp;
using Microsoft.AspNetCore.Http;

namespace Demo01WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Bank _context;

        public HomeController(Bank context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateChecking()
        {
            return View();
        }
        public IActionResult CreateTerm()
        {
            return View();
        }

        public IActionResult CreateLoan()
        {
            return View();
        }
        public IActionResult CreateBusiness()
        {
            return View();
        }


        public IActionResult Details(int? id)
        {
            return View();
        }
    }
}
