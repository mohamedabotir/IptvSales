using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace Iptv.Domain.Entities
{
    public class Plan
    {
        [HiddenInput(DisplayValue = false)]
        public int id { get; set; }
        [Required]
        [Display(Name = "PlanName")]
        public string name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public int price { get; set; }
        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string description { get; set; }
        [Required]
        [Display(Name = "usedTime")]
        public int usedTime { get; set; }
        [Display(Name = "SharedNumber")]
        public int sharedNumebr { get; set; }
        
        [Display(Name ="Plan Image")]
        [DataType(DataType.Upload)]
        public byte[] ImageData { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }
    }
}
