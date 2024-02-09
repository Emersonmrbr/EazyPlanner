using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyPlanner.Domain.Entities
{
    [Table("FinanceCategory")]
    public class FinanceCategory : _CreateBase
    {
        public FinanceCategory(int financeCategoryId, string name, string? createdBy, DateTime? createDate, string? updateBy, DateTime? updateDate)
        {
            FinanceCategoryId = financeCategoryId;
            Name = name;
            CreatedBy = createdBy;
            CreateDate = createDate;
            UpdateBy = updateBy;
            UpdateDate = updateDate;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FinanceCategoryId { get; private set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(255, ErrorMessage = "Name must be at most 255 characters.")]
        public required string Name { get; set; }

        [ForeignKey(nameof(FinanceCategory))]
        public int? FinancialRecordId { get; set; }

        public FinancialRecord? FinancialRecord { get; set; }
    }
}