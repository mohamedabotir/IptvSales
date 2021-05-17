using System;
using System.Linq;
using Iptv.Domain.Abstract;
using Iptv.Domain.Entities;
using IptvSales.Controllers;
using IptvSales.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Iptv.Test
{
    [TestClass]
    public class plans
    {
        [TestMethod]
        public void get_latest_three_plans()
        {
            Mock<IPlanRepository> mock = new Mock<IPlanRepository>();
            mock.Setup(e => e.planes).Returns(
               new Plan[] {
                   new Plan{ id = 1,description = "temp1",name="p1",price = 12,sharedNumebr = 1,usedTime = 10},
                   new Plan{ id = 2,description = "temp2",name="p2",price = 133,sharedNumebr = 3,usedTime = 20},
                   new Plan{ id = 3,description = "temp3",name="p3",price = 15,sharedNumebr = 4,usedTime = 5},

               }.AsQueryable()
                );
            HomeController target = new HomeController(mock.Object);
            Plan[] data = ((IEnumerable<Plan>)target.Index().Model).ToArray();
             Console.WriteLine(data[0].id);
            Assert.AreEqual(3, data[0].id);
            
        }
    }
}
