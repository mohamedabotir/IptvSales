﻿using IptvSales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IptvSales.Domain.Concrete
{
    class EFdbContext :DbContext
    {
       public DbSet<Plan> plans { set; get; }
    }
}
