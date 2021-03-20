using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty(); 
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).EmailAddress();
            //RuleFor(u => u.Password).NotEmpty();        alttaki varken buna gerek yok
            //RuleFor(u => u.Password).MinimumLength(6);  .PasswordSalt veya .PasswordHash yap
        }
    }
}
