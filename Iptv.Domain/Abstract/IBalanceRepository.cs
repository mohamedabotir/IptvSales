using Iptv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iptv.Domain.Abstract
{
    public interface IBalanceRepository
    {
        IQueryable<Balance> balances {  get; }
        void setBalance(Balance balance);
    }
}
