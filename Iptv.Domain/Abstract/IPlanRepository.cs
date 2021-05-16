using Iptv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iptv.Domain.Abstract
{
   public interface IPlanRepository
    {
        IQueryable<Plan> planes { get; }
        void savePlan(Plan plan);
    }
}
