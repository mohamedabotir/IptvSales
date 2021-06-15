using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Iptv.Domain.Entities
{
    public class Cart
    {
        [Required]
        [HiddenInput(DisplayValue = false)]
        public int id { get; set; }
        [Required]
        public string userId { get; set; }

        public Plan plan { get; set; }
        public int usedTime { get; set; }

    }
}
