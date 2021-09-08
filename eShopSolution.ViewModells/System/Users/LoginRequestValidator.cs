using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username is requiered");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is requiered")
                .MinimumLength(6).WithMessage("Password is ad least 6 characters");
        }
    }
}