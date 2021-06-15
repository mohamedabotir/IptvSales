using Iptv.Domain.Abstract;
using Iptv.Domain.Entities;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IptvSaless.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IPlanRepository planRepository;
        public ICartRepository cartRepository;
        public IBalanceRepository balanceRepository;
        List<Cart> carts;
        public UserController(IBalanceRepository balanceRepository, IPlanRepository planRepository, ICartRepository cartRepository)
        {
            carts = new List<Cart>();
            this.cartRepository = cartRepository;
            this.planRepository = planRepository;
            this.balanceRepository = balanceRepository;
        }
        public ActionResult addToCart(int id)
        {

            Plan planData = planRepository.planes.FirstOrDefault(e => e.id == id);
            if (planData != null)
            {
                Cart data = new Cart
                {
                    plan = planData,
                    usedTime = planData.usedTime - 1,
                    userId = User.Identity.GetUserId()
                };
                foreach (var item in (List<Cart>)Session["Cart"])
                {
                    carts.Add(item);
                }
                carts.Add(data);


                Session["Cart"] = carts;
            }
            return RedirectToAction("index", "plan", "default");
        }
        public ViewResult Cart(List<Cart> cart)
        {

            return View(cart);
        }

    }
}