using Microsoft.Build.Framework;

namespace DAL.Models
{
    public class User_Auth
     {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
