using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{

    public class FinancialRecord(int id, string description, DateTime plannedDate, decimal plannedAmount, DateTime? receivedDate, decimal? receivedAmount, string recordType, string? status, CreateBase? create, int? bankrollAccountId, BankrollAccount? bankrollAccount, int? costeCenterId, CostCenter? costCenter, int? customerSupplierId, CustomerSupplier? customerSupplier, int? financeCategoryId, FinanceCategory? financeCategory, int? invoiceId, Invoice? invoice, int? paymentMethodId, PaymentMethod? paymentMethod)
    {
        public int Id { get; private set; } = id;
        public required string Description { get; set; } = description;
        public required DateTime PlannedDate { get; set; } = plannedDate;
        public required decimal PlannedAmount { get; set; } = plannedAmount;
        public DateTime? ReceivedDate { get; set; } = receivedDate;
        public decimal? ReceivedAmount { get; set; } = receivedAmount;
        public required string RecordType { get; set; } = recordType;
        public string? Status { get; set; } = status;
        public CreateBase? Create { get; set; } = create;

        public int? BankrollAccountId { get; private set; } = bankrollAccountId;
        public BankrollAccount? BankrollAccount { get; private set; } = bankrollAccount;
        public int? CosteCenterId { get; private set; } = costeCenterId;
        public CostCenter? CostCenter { get; private set; } = costCenter;
        public int? CustomerSupplierId { get; private set; } = customerSupplierId;
        public CustomerSupplier? CustomerSupplier { get; private set; } = customerSupplier;
        public int? FinanceCategoryId { get; private set; } = financeCategoryId;
        public FinanceCategory? FinanceCategory { get; private set; } = financeCategory;
        public int? InvoiceId { get; private set; } = invoiceId;
        public Invoice? Invoice { get; private set; } = invoice;
        public int? PaymentMethodId { get; private set; } = paymentMethodId;
        public PaymentMethod? PaymentMethod { get; private set; } = paymentMethod;
    }
}
