using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class PaymentMethod(int paymentMethodId,
                         string name)
    {
        public int PaymentMethodId { get; private set; } = paymentMethodId;
        public required string Name { get; set; } = name;
        public CreateBase Create { get; set; } = new CreateBase(string.Empty, DateTime.Now, string.Empty, DateTime.Now);

        public ICollection<FinancialRecord> FinancialRecords { get; private set; } = [];

    }
}
