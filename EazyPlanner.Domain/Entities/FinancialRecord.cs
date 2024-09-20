using EazyPlanner.Domain.Bases;

namespace EazyPlanner.Domain.Entities
{

    public class FinancialRecord(int id, string description, DateTime plannedDate, decimal plannedAmount, DateTime? receivedDate, decimal? receivedAmount, string recordType, string? status)
    {
        public int Id { get; private set; } = id;
        public string Description { get; set; } = description;
        public DateTime PlannedDate { get; set; } = plannedDate;
        public decimal PlannedAmount { get; set; } = plannedAmount;
        public DateTime? ReceivedDate { get; set; } = receivedDate;
        public decimal? ReceivedAmount { get; set; } = receivedAmount;
        public string RecordType { get; set; } = recordType;
        public string? Status { get; set; } = status;

        public CreateBase? Create { get; set; } = new();

        public int? BankrollAccountId { get; private set; } = 0;
        public BankrollAccount? BankrollAccount { get; private set; } = new(0, string.Empty);
        public int? CosteCenterId { get; private set; } = 0;
        public CostCenter? CostCenter { get; private set; } = new(0,string.Empty);
        public int? CustomerSupplierId { get; private set; } = 0;
        public CustomerSupplier? CustomerSupplier { get; private set; } = new(0,string.Empty,string.Empty);
        public int? FinanceCategoryId { get; private set; } = 0;
        public FinanceCategory? FinanceCategory { get; private set; } = new(0,string.Empty);
        public int? InvoiceId { get; private set; } = 0;
        public Invoice? Invoice { get; private set; } = new(0,string.Empty,string.Empty,0,DateTime.UtcNow,string.Empty);
        public int? PaymentMethodId { get; private set; } = 0;
        public PaymentMethod? PaymentMethod { get; private set; } = new(0,string.Empty);
    }
}
