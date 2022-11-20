using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EventManagementWeb.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Geçerli Parola alanı boş bırakılamaz.")]
        [Display(Name = "Eski Şifre:")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Yeni Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre:")]
        public string NewPassword { get; set; }

        [Compare(nameof(NewPassword), ErrorMessage = "Şifreler aynı değildir.")]
        [Required(ErrorMessage = "Yeni Şifre Tekrarı alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre Tekrarı :")]
        public string ConfirmNewPassword { get; set; }
    }
}
