using EazyPlanner.Domain.Entities;
using FluentValidation;

namespace EazyPlanner.Infrastructure.EntityValidation
{
    public class CustomerSupplierValidation : AbstractValidator<CustomerSupplier>
    {
        public CustomerSupplierValidation()
        {
            RuleFor(r => r.CNPJ)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .MaximumLength(50).WithMessage("{PropertyName} não pode conter masi que {MaxLength} caracteres");
            RuleFor(r => r.CompanyName)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório")
                .MaximumLength(100).WithMessage("{PropertyName} não pode conter mais que {MaxLength} caracteres");
            RuleFor(r => r.CompanyFantasy)
                .MaximumLength(100)
                .WithMessage("{PropertyName} não pode conter mais que {MaxLength} caracteres");
            RuleFor(r => r.ProvinceId)
                .MaximumLength(30)
                .WithMessage("{PropertyName} não pode conter mais que {MaxLength} caracteres");
            RuleFor(r => r.CityId)
                .MaximumLength(30)
                .WithMessage("{PropertyName} não pode conter mais que {MaxLength} caracteres");
        }
    }
}
