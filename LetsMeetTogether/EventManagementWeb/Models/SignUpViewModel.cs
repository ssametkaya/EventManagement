using System.ComponentModel.DataAnnotations;

namespace EventManagementWeb.Models
{
    public class SignUpViewModel
    {
        //public SignUpViewModel()
        //{

        //}
        //public SignUpViewModel(string userName, string nameSurname, string email, string password, string passwordConfirm)
        //{
        //    UserName = userName;    
        //    NameSurname = nameSurname;
        //    Email = email;
        //    Password = password;
        //    PasswordConfirm = passwordConfirm;
        //}

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public string Id { get; set; }

        [Required(ErrorMessage = "Ad-Soyad alanı boş bırakılamaz.")]
        [Display(Name = "Ad-Soyad :")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı:")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Email Formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre :")]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Şifreler aynı değildir.")]
        [Required(ErrorMessage = "Şifre Tekrarı alanı boş bırakılamaz.")]
        [Display(Name = "Şifre Tekrarı :")]
        public string PasswordConfirm { get; set; }
    }
}
