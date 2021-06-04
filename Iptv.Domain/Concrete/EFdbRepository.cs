using Iptv.Domain.Abstract;
using Iptv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iptv.Domain.Concrete
{
  public class EFdbRepository : IPlanRepository,IBalanceRepository
    {
       private EFdbContext dbContext = new EFdbContext();
        public IQueryable<Plan> planes {
            get { return dbContext.plans; } }

        public IQueryable<Balance> balances {
            get { return dbContext.balances; } }

        public void remove(int id)
        {
            Plan dataPlan = dbContext.plans.Find(id);
            if (dataPlan != null) {
                dbContext.plans.Remove(dataPlan);
                dbContext.SaveChanges();
                    }
        }

        public void savePlan(Plan plan)
        {
            if (plan.id == 0) {// if new plan
                dbContext.plans.Add(plan);
            }
            else
            {
                //update
                Plan dataplan = dbContext.plans.Find(plan.id);
                dataplan.name = plan.name;
                dataplan.price = plan.price;
                dataplan.sharedNumebr = plan.sharedNumebr;
                dataplan.usedTime = plan.usedTime;
                dataplan.ImageData = plan.ImageData;
                dataplan.ImageMimeType = plan.ImageMimeType;
                
            }
            dbContext.SaveChanges();
        }

        public void setBalance(Balance balance)
        {
            Balance accountBalacne;
            if (balance.id !=null) {
                accountBalacne = dbContext.balances.Find(balance.id);
                if (accountBalacne != null)
                    return;
                dbContext.balances.Add(balance);
            }
            else
            {

            }
            dbContext.SaveChanges();
        }
    }
}
