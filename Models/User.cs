using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace D_Einder_Dylaan_MVC.Models
{
    public class User : IdentityUser
    {

        [Required]
        public string Name { get; set; }

        public string RoleId { get; set; }

        public string Role { get; set; }


    }
}
