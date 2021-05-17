using Iptv.Domain.Abstract;
using Iptv.Domain.Entities;
using IptvSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IptvSales.Controllers
{
    public class HomeController : Controller
    {
       public IPlanRepository planRepo;
        public HomeController(IPlanRepository repo) {
            this.planRepo = repo;
        }
        // GET: Home
        public ViewResult Index()
        {
           /* ListViewPlans p = new ListViewPlans
            {
                plans = planRepo.planes.OrderByDescending(e => e.id).Take(3)
            };*/
            IEnumerable<Plan> p = planRepo.planes.OrderByDescending(e => e.id).Take(3);
            return View(p);
        }
        public ViewResult test() {
            ListViewPlans p = new ListViewPlans
            {
                plans = planRepo.planes
            };
            return View(p);
        }
    }
}