using EazyPlanner.Domain.Bases;
using EazyPlanner.Domain.Enums;

namespace EazyPlanner.Domain.Entities
{

    public class FinancialRecord(int id, string description, DateTime plannedDate, decimal plannedAmount)
    {
        public int Id { get; private set; } = id;
        public string Description { get; set; } = description;
        public RecordType RecordType { get; set; } = RecordType.Revenue;
        public DateTime PlannedDate { get; set; } = plannedDate;
        public decimal PlannedAmount { get; set; } = plannedAmount;
        public DateTime? ReceivedDate { get; set; } = DateTime.UtcNow;
        public decimal? ReceivedAmount { get; set; } = 0;
        public StatusType? Status { get; set; } = StatusType.Open;

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
