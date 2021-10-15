using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Validator
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
            RuleFor(c => c.ProductId).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
            RuleFor(c => c.UserId).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
            RuleFor(c => c.Mount).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
        }
    }
}
