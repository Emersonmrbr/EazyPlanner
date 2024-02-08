using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyPlanner.Domain.Entities
{

    [Table("People")]
    public class People : AddressContact
    {
        public People(int peopleId, string name, DateTime birthDate, string? genre, string? createdBy, DateTime? createDate, string? updateBy, DateTime? updateDate)
        {
            PeopleId = peopleId;
            Name = name;
            BirthDate = birthDate;
            Genre = genre;
            CreatedBy = createdBy;
            CreateDate = createDate;
            UpdateBy = updateBy;
            UpdateDate = updateDate;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PeopleId { get; private set; }

        [Required(ErrorMessage = "The Name field is required")]
        [StringLength(200, ErrorMessage = "The Name field cannot be longer than 200 characters")]
        [DataType(DataType.Text)]
        public required string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [StringLength(10, ErrorMessage = "The Genre field cannot be longer than 10 characters")]
        [DataType(DataType.Text)]
        public string? Genre { get; set; }

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