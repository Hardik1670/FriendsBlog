using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MvcFriendsSite.Models
{
    public class SocialModel
    {


        public int Id { get; set; }
        [Display(Name = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string userName { get; set; }

      


        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Display Picture")]
        public string profilePicUrl { get; set; }

        [Display(Name = "Friend's Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string friendsEmail { get; set; }


    }
}
