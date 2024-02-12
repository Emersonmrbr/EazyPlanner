using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{

    public class FinancialRecord(int financialRecordId,
                           string recordType,
                           string description,
                           DateTime dueDate,
                           decimal plannedAmount,
                           decimal? actualAmount,
                           DateTime? receivedDate,
                           string? status)
    {
        public int FinancialRecordId { get; private set; } = financialRecordId;

        public required string RecordType { get; set; } = recordType;

        public required string Description { get; set; } = description;
        public required DateTime DueDate { get; set; } = dueDate;

        public required decimal PlannedAmount { get; set; } = plannedAmount;
        public DateTime? ReceivedDate { get; set; } = receivedDate;
        public decimal? ActualAmount { get; set; } = actualAmount;
        public string? Status { get; set; } = status;
        public CreateBase? Create { get; set; }

        public int? BankrollAccountId { get; set; }
        public BankrollAccount? BankrollAccount { get; private set; }
        public int? CosteCenterId { get; set; }
        public CostCenter? CostCenter { get; private set; }
        public int? CustomerSupplierId { get; set; }
        public CustomerSupplier? CustomerSupplier { get; private set; }
        public int? FinanceCategoryId { get; set; }
        public FinanceCategory? FinanceCategory { get; private set; }
        public int? InvoiceId { get; set; }
        public Invoice? Invoice { get; private set; }
        public int? PaymentMethodId { get; set; }
        public PaymentMethod? PaymentMethod { get; private set; }
    }
}
