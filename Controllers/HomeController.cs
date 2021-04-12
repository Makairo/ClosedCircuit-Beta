using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedCircuit.Models;

namespace ClosedCircuit.Controllers
{
    public class HomeController : Controller
    {
        private IGameRepo repository;

        public HomeController(IGameRepo repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Scores()
        {
            return View(repository.Rounds);
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
