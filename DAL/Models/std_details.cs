using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class std_details
    {
        [Key]
        [BindNever]
        public int id { get; set; }
        [Required]
        public string email { get; set; }
        public string name { get; set; }
        public string father_name { get; set; }
        public string password { get; set; }
    }
}
