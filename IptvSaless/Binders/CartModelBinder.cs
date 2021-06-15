using Iptv.Domain.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IptvSaless.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string sesionKey = "Cart";
        List<Cart> cart;
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {

            cart = (List<Cart>)controllerContext.HttpContext.Session[sesionKey];
            if (cart == null)
            {
                cart = new List<Cart>();
                controllerContext.HttpContext.Session[sesionKey] = cart;
            }
            return cart;
        }
    }
}