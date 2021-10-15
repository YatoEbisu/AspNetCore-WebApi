using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities.Validator
{
    public static class Validator<T>
    {
        public static bool IsValid(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                return false;

            var result = validator.Validate(obj);
            if (result.IsValid) return true;

            return false;
        }
    }
}
