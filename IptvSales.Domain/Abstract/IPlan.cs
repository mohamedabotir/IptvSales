using IptvSales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IptvSales.Domain.Abstract
{
    interface IPlanRepository
    {
        IQueryable<Plan> planes { get; }
        void savePlan(Plan plan);
    }
}
