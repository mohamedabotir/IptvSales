using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace Iptv.Domain.Entities
{
   public class Balance
    {
        [HiddenInput(DisplayValue = false)]
        public string id { get; set; }
        public decimal balance { get; set; }
    }
}
