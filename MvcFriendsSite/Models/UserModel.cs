using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcFriendsSite.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string userName { get; set; }
        [Display(Name = "Gender")]
        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string gender { get; set; }

        [Display(Name = "Alias")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string alias { get; set; }


        [Display(Name = "Website")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string website { get; set; }


        [Display(Name = "Social Website")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string socialWebsite { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime dob { get; set; }

        public ICollection<SocialModel> userToSocialFK { get; set; }



    }
}
