using Iptv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IptvSaless.Models
{
    public class ListViewPlans
    {
       public IEnumerable<Plan> plans { set; get; }
        /*public int sharedNumber { get; set; }
        [Required]
        [Display(Name = "usedTime")]
        public int usedTime { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public int price { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }
        [Required]
        [Display(Name ="PlanName")]
        public string name { get; set; }*/
    }
}