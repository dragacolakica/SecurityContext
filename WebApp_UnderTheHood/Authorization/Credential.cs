using System.ComponentModel.DataAnnotations;

namespace WebAppSecurity.Authorization
{
    public class Credential
    {
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
