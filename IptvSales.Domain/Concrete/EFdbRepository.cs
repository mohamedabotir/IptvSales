using IptvSales.Domain.Abstract;
using IptvSales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IptvSales.Domain.Concrete
{
    class EFdbRepository : IPlanRepository
    {
        EFdbContext dbContext = new EFdbContext();
        public IQueryable<Plan> planes {
            get { return dbContext.plans; } }

        public void savePlan(Plan plan)
        {
            if (plan.id == 0) {// if new plan
                dbContext.plans.Add(plan);
            }
            else
            {

            }
        }
    }
}
