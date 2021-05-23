using Iptv.Domain.Abstract;
using IptvSaless.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IptvSales.Controllers
{
    public class PlanController : Controller
    {
        public IPlanRepository planRepo;
        public PlanController(IPlanRepository repo)
        {
            this.planRepo = repo;
        }
        // GET: Plan
        public ActionResult Index()
        {
            ViewBag.MainTitle = "Plans";
            ViewBag.SubTitle = "Choose Your Plan";
            ListViewPlans p = new ListViewPlans
            {
                plans = planRepo.planes
            };
            return View(p);
        }
    }
}