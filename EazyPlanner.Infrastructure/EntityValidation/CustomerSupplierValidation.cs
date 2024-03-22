using EazyPlanner.Domain.Entities;
using FluentValidation;

namespace EazyPlanner.Infrastructure.EntityValidation
{
    public class CustomerSupplierValidation : AbstractValidator<CustomerSupplier>
    {
        public CustomerSupplierValidation()
        {
            RuleFor(customerSupplier => customerSupplier.CNPJ).NotEmpty();

        }
    }
}
