using EazyPlanner.Domain.Entities.Base;

namespace EazyPlanner.Domain.Entities
{
    public class PaymentMethod
    {
        public PaymentMethod(int paymentMethodId,
                             string name,
                            CreateBase? create)
        {
            PaymentMethodId = paymentMethodId;
            Name = name;
            Create = create;
        }

        public int PaymentMethodId { get; private set; }
        public required string Name { get; set; }
        public CreateBase? Create { get; set; }
        public int? FinancialRecordId { get; set; }

    }
}
