using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyPlanner.Domain.Entities
{

    [Table("FinancialRecord")]
    public class FinancialRecord
    {
        public FinancialRecord(int financialRecordId, string recordType, string description, DateTime dueDate, decimal plannedAmount, decimal? actualAmount, string? status, DateTime? receivedDate, string? account, string? client, string? category, string? costCenter, string? invoice, string? invoiceNumber, string? createdBy, DateTime? createDate, string? updateBy, DateTime? updateDate)
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
            CreatedBy = createdBy;
            CreateDate = createDate;
            UpdateBy = updateBy;
            UpdateDate = updateDate;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FinancialRecordId { get; private set; }

        [Required(ErrorMessage = "Record Type is required.")]
        [MaxLength(255, ErrorMessage = "Account must be at most 255 characters.")]
        [DataType(DataType.Text)]
        public required string RecordType { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(255, ErrorMessage = "Account must be at most 255 characters.")]
        [DataType(DataType.Text)]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Due Date is required.")]
        [DataType(DataType.Date)]
        public required DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Planned Amount is required.")]
        [DataType(DataType.Currency)]
        public required decimal PlannedAmount { get; set; }

        [DataType(DataType.Currency)]
        public decimal? ActualAmount { get; set; }

        [MaxLength(100, ErrorMessage = "Status must be at most 100 characters.")]
        [DataType(DataType.Text)]
        public string? Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReceivedDate { get; set; }

        [MaxLength(100, ErrorMessage = "Account must be at most 100 characters.")]
        public string? Account { get; set; }

        [MaxLength(100, ErrorMessage = "Client must be at most 100 characters.")]
        [DataType(DataType.Text)]
        public string? Client { get; set; }

        [MaxLength(100, ErrorMessage = "Category must be at most 100 characters.")]
        [DataType(DataType.Text)]
        public string? Category { get; set; }

        [MaxLength(100, ErrorMessage = "Cost Center must be at most 100 characters.")]
        [DataType(DataType.Text)]
        public string? CostCenter { get; set; }

        [MaxLength(100, ErrorMessage = "Invoice must be at most 100 characters.")]
        [DataType(DataType.Text)]
        public string? Invoice { get; set; }

        [MaxLength(100, ErrorMessage = "Invoice must be at most 100 characters.")]
        [DataType(DataType.Text)]
        public string? InvoiceNumber { get; set; }

        [DataType(DataType.Text)]
        public string? CreatedBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreateDate { get; set; }

        [DataType(DataType.Text)]
        public string? UpdateBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        public ICollection<CustomerSupplier> CustomersSuppliers { get; } = new List<CustomerSupplier>();
        public ICollection<People> Peoples { get; } = new List<People>();
        public ICollection<BankrollAccount> BankrollAccounts { get; } = new List<BankrollAccount>();
        public ICollection<CostCenter> CostCenters { get; } = new List<CostCenter>();
        public ICollection<FinanceCategory> FinanceCategories { get; } = new List<FinanceCategory>();
        public ICollection<Invoice> Invoices { get; } = new List<Invoice>();
        public ICollection<PaymentMethod> PaymentMethods { get; } = new List<PaymentMethod>();

    }
}
