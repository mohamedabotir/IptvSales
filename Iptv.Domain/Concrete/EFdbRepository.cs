using Iptv.Domain.Abstract;
using Iptv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iptv.Domain.Concrete
{
  public class EFdbRepository : IPlanRepository
    {
       private EFdbContext dbContext = new EFdbContext();
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
