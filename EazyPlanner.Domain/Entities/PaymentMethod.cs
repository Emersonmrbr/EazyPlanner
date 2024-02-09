using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyPlanner.Domain.Entities
{
    [Table("PaymentMethod")]
    public class PaymentMethod : _CreateBase
    {
        public PaymentMethod(int paymentMethodId, string name, string? createdBy, DateTime? createDate, string? updateBy, DateTime? updateDate)
        {
            PaymentMethodId = paymentMethodId;
            Name = name;
            CreatedBy = createdBy;
            CreateDate = createDate;
            UpdateBy = updateBy;
            UpdateDate = updateDate;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentMethodId { get; private set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name must be at most 100 characters.")]
        public required string Name { get; set; }

        [ForeignKey(nameof(FinanceCategory))]
        public int? FinancialRecordId { get; set; }

        public FinancialRecord? FinancialRecord { get; set; }
    }
}
