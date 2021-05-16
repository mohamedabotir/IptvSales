using Iptv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IptvSales.Models
{
    public class ListViewPlans
    {
       public IEnumerable<Plan> plans { set; get; }
    }
}