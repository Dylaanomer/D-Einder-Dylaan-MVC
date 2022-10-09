using Microsoft.AspNetCore.Identity;

namespace D_Einder_Dylaan_MVC.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string RoleId { get; set; }

        public string Role { get; set; }


    }
}
