using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyPlanner.Domain.Entities
{
    [Table("CustomerSupplier")]
    public class CustomerSupplier : AddressContact
    {
        public CustomerSupplier(int customerSupplierId, string cNPJ, string companyName, string? companyFantasy, string? people, string? provinceId, string? cityId, string? createdBy, DateTime? createDate, string? updateBy, DateTime? updateDate)
        {
            CustomerSupplierId = customerSupplierId;
            CNPJ = cNPJ;
            CompanyName = companyName;
            CompanyFantasy = companyFantasy;
            People = people;
            ProvinceId = provinceId;
            CityId = cityId;
            CreatedBy = createdBy;
            CreateDate = createDate;
            UpdateBy = updateBy;
            UpdateDate = updateDate;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerSupplierId { get; private set; }

        [Required(ErrorMessage = "The CNPJ field is required")]
        [StringLength(50, ErrorMessage = "The CNPJ field must be 50 characters")]
        [DataType(DataType.Text)]
        public required string CNPJ { get; set; }

        [Required(ErrorMessage = "The Company name field is required")]
        [StringLength(200, ErrorMessage = "The Company name field cannot be longer than 200 characters")]
        [DataType(DataType.Text)]
        public required string CompanyName { get; set; }

        [StringLength(100, ErrorMessage = "The Company fantasy field cannot be longer than 100 characters")]
        [DataType(DataType.Text)]
        public string? CompanyFantasy { get; set; }

        [StringLength(200, ErrorMessage = "The People field cannot be longer than 200 characters")]
        [DataType(DataType.Text)]
        public string? People { get; set; }

        [StringLength(30, ErrorMessage = "The Province id field cannot be longer than 30 characters")]
        [DataType(DataType.Text)]
        public string? ProvinceId { get; set; }

        [StringLength(30, ErrorMessage = "The City id field cannot be longer than 30 characters")]
        [DataType(DataType.Text)]
        public string? CityId { get; set; }

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