using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp2.DTOs;

namespace WebAPIApp2.Validators.Product
{
    public class ProductPostDtoValidator:AbstractValidator<ProductPostDto>
    {
        public ProductPostDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(255);
            RuleFor(p => p.Count).GreaterThanOrEqualTo(0);
            RuleFor(p => p.Price).GreaterThanOrEqualTo(0);
        }
    }
}
