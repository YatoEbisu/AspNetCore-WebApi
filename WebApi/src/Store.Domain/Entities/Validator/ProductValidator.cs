using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Validator
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
             RuleFor(c => c.Id).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
             RuleFor(c => c.Name).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
             RuleFor(c => c.Brand).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
             RuleFor(c => c.Price).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
             RuleFor(c => c.inventory).NotEmpty().WithMessage("The {PropertyName} field cannot be empty");
        }
    }
}
