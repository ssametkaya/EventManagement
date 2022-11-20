using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.CustomValidator
{
    public class PasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            var errors = new List<IdentityError>();

            Regex regex = new Regex("[^A-Za-z0-9]+.{8}");

            //Şifrede büyük küçük farketmeksizin bir harf içermesi durumuna çözüm bak.
            //if (!regex.IsMatch(password))
            //{
            //    errors.Add(new IdentityError()
            //    {
            //        Code = "PasswordDoesntContainLetter",
            //        Description = "Şifre en az 1 harf içermelidir."
            //    });
            //}

            if (!errors.Any())
            {
                return Task.FromResult(IdentityResult.Success);
            }

            return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
        }
    }
}
