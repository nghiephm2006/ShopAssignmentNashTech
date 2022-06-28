﻿using FluentValidation;
using ShopAssignment.ViewModels.System.Users.Request;

namespace ShopAssignment.ViewModels.System.Users.Validator
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
            RuleFor(X => X.Password).NotEmpty().WithMessage("Password is required").MinimumLength(6).WithMessage("Password is at least 6 characters");
        }
    }
}