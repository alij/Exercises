using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review
    {
        [Display(Name = "Username")]
        public string Username { get; set; }
        
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [Display(Name = "ReviewTitle")]
        public string ReviewTitle { get; set; }

        [Display(Name = "ReviewText")]
        public string ReviewText { get; set; }

        [Display(Name = "ReviewDate")]
        public DateTime ReviewDate { get; set; }
    }
}
