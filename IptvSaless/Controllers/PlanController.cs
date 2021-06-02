using Iptv.Domain.Abstract;
using Iptv.Domain.Entities;
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
        public FileContentResult GetImage(int id)
        {
            Plan data = planRepo.planes.FirstOrDefault(e => e.id == id);
            if (data != null)
            {
                return File(data.ImageData, data.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
        [Authorize(Roles = "admin")]
        public ActionResult List() {
            ListViewPlans listViewPlans = new ListViewPlans {
                plans = planRepo.planes.OrderBy(e => e.id)
            };
            return View(listViewPlans);
        }
    }
}