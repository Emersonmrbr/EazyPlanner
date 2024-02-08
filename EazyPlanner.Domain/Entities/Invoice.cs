using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyPlanner.Domain.Entities
{
    [Table("Invoice")]
    public class Invoice
    {
        public Invoice(int invoiceId, string name, string number, decimal amount, DateTime date, string file, string? createdBy, DateTime? createDate, string? updateBy, DateTime? updateDate)
        {
            InvoiceId = invoiceId;
            Name = name;
            Number = number;
            Amount = amount;
            Date = date;
            File = file;
            CreatedBy = createdBy;
            CreateDate = createDate;
            UpdateBy = updateBy;
            UpdateDate = updateDate;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; private set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(255, ErrorMessage = "Name must be at most 255 characters.")]
        [DataType(DataType.Text)]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Number is required.")]
        [MaxLength(255, ErrorMessage = "Number must be at most 255 characters.")]
        [DataType(DataType.Text)]
        public required string Number { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [DataType(DataType.Currency)]
        public required decimal Amount { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        public required DateTime Date { get; set; }

        [Required(ErrorMessage = "File is required.")]
        [MaxLength(255, ErrorMessage = "File must be at most 255 characters.")]
        [DataType(DataType.Text)]
        public required string File { get; set; }

        [DataType(DataType.Text)]
        public string? CreatedBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreateDate { get; set; }

        [DataType(DataType.Text)]
        public string? UpdateBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [ForeignKey(nameof(FinanceCategory))]
        public int? FinancialRecordId { get; set; }

        public FinancialRecord? FinancialRecord { get; set; }
    }
}