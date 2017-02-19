using System.ComponentModel.DataAnnotations;

namespace WebAdvanced.Session_3.Models
{
    public class Tester
    {
        [Required]
        [RegularExpression("([a-zA-Z0-9])*", ErrorMessage = "Only Letters and Numbers")]
        public string userName { get; set; }

        [Required]
        public string passWord { get; set; }
        public string fullName { get; set; }

        [EmailAddress]
        [Required]
        [RegularExpression("([a-zA-Z0-9@a-zA-Z.a-zA-Z])*", ErrorMessage = "Please input right valid")]
        public string email { get; set; }

        [Required]
        [RegularExpression("([0-9])*", ErrorMessage = "Just Only Number")]
        public string phone { get; set; }
    }
}