using EazyPlanner.Domain.Entities;
using FluentValidation;


namespace EazyPlanner.Infrastructure.EntityValidation
{
    public class CostCenterValidation : AbstractValidator<CostCenter>
    {
        public CostCenterValidation()
        {
            RuleFor(costeCenter => costeCenter.Name).NotEmpty();
        }
    }
}
