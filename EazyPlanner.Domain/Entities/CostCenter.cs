using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyPlanner.Domain.Entities
{
    [Table("CostCenter")]
    public class CostCenter
    {
        public CostCenter(int costCenterId, string name, string? createdBy, DateTime? createDate, string? updateBy, DateTime? updateDate)
        {
            CostCenterId = costCenterId;
            Name = name;
            CreatedBy = createdBy;
            CreateDate = createDate;
            UpdateBy = updateBy;
            UpdateDate = updateDate;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CostCenterId { get; private set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name must be at most 100 characters.")]
        [DataType(DataType.Text)]
        public required string Name { get; set; }

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