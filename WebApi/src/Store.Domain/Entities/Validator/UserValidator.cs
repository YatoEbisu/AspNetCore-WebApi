using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
            RuleFor(c => c.Login).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
            RuleFor(c => c.Password).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
        }
    }
}
