using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EventManagementWeb.Models
{
    public class SignInViewModel
    {
        [EmailAddress(ErrorMessage = "Email Formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre :")]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
