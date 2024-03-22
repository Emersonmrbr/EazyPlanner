using EazyPlanner.Domain.Entities;
using FluentValidation;

namespace EazyPlanner.Infrastructure.EntityValidation
{
    public class BankrollAccountValidation : AbstractValidator<BankrollAccount>
    {
        public BankrollAccountValidation()
        {
            RuleFor(bankroll => bankroll.Name).NotEmpty();
        }
    }


}
