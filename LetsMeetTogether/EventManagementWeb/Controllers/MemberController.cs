using EntityLayer.Concrete;
using EventManagementWeb.Extensions;
using EventManagementWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementWeb.Controllers
{
    public class MemberController : Controller
    {
        private readonly UserManager<AppUser> _UserManager;

        private readonly SignInManager<AppUser> _SignInManager;


        public MemberController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var identityResult = await _UserManager.CreateAsync(new()
            {
                UserName = request.UserName,
                Email = request.Email,
                NameSurname = request.NameSurname
            }, request.PasswordConfirm);


            if (identityResult.Succeeded)
            {
                TempData["SuccessMessage"] = "Üyelik Kayıt İşlemi Başarılı Gerçeklemiştir.";
                return RedirectToAction(nameof(MemberController.SignUp));
            }

            ModelState.AddModelErrorList(identityResult.Errors.Select(x => x.Description).ToList());

            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            //returnUrl = returnUrl ?? Url.Action("Index", "Home");

            var hasUser = await _UserManager.FindByEmailAsync(model.Email);

            if (hasUser == null)
            {
                ModelState.AddModelError(string.Empty, "Email veya şifre yanlış.");
                return View();
            }

            var signInResult = await _SignInManager.PasswordSignInAsync(hasUser, model.Password, model.RememberMe, true);

            if (signInResult.Succeeded)
            {
                TempData["Giriş"] = hasUser.Email;

                return RedirectToAction("Index", "Home");

            }
            ModelState.AddModelErrorList(new List<string>() { "Email veya şifre yanlış." });
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _SignInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ChangePassword()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _UserManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("SignIn", "Member");
                }

                var result = await _UserManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

                if (result.Succeeded)
                {
                    TempData["ChangePassword"] = "Şifre Değiştirildi.";
                    return RedirectToAction("SignIn", "Member");
                }


            }


            return View();
        }

    }
}
