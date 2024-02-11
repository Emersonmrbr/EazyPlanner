using EazyPlanner.Domain.Entities.Base;

namespace EazyPlanner.Domain.Entities
{

    public class FinancialRecord
    {
        public FinancialRecord(int financialRecordId,
                               string recordType,
                               string description,
                               DateTime dueDate,
                               decimal plannedAmount,
                               decimal? actualAmount,
                               string? status,
                               DateTime? receivedDate,
                               string? account,
                               string? client,
                               string? category,
                               string? costCenter,
                               string? invoice,
                               string? invoiceNumber,
                               CreateBase create)
        {
            FinancialRecordId = financialRecordId;
            RecordType = recordType;
            Description = description;
            DueDate = dueDate;
            PlannedAmount = plannedAmount;
            ActualAmount = actualAmount;
            Status = status;
            ReceivedDate = receivedDate;
            Account = account;
            Client = client;
            Category = category;
            CostCenter = costCenter;
            Invoice = invoice;
            InvoiceNumber = invoiceNumber;
            Create = create;
        }

        public int FinancialRecordId { get; private set; }

        public required string RecordType { get; set; }

        public required string Description { get; set; }
        public required DateTime DueDate { get; set; }

        public required decimal PlannedAmount { get; set; }
        public decimal? ActualAmount { get; set; }

        public string? Status { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public string? Account { get; set; }

        public string? Client { get; set; }

        public string? Category { get; set; }

        public string? CostCenter { get; set; }

        public string? Invoice { get; set; }

        public string? InvoiceNumber { get; set; }
        public CreateBase? Create { get; set; }
        public int? BankrollAccountId { get; set; }
        public int? CosteCenterId { get; set; }
        public int? CustomerSupplierId { get; set; }
        public int? FinanceCategoryId { get; set; }
        public int? InvoiceId { get; set; }
        public int? PaymentMethodId { get; set; }

        public List<BankrollAccount>? BankrollAccounts { get; set; }
        public List<CostCenter>? CostCenters { get; set; }
        public List<CustomerSupplier>? CustomerSuppliers { get; set; }
        public List<FinanceCategory>? FinanceCategories { get; set; }
        public List<Invoice>? Invoices { get; set; }
        public List<PaymentMethod>? PaymentMethods { get; set; }


    }
}
