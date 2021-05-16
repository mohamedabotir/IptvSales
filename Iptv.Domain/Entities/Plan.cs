using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iptv.Domain.Entities
{
    public class Plan
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public int usedTime { get; set; }
        public int sharedNumebr { get; set; }
    }
}
