using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class CustomerSupplier(int customerSupplierId,
                            string cNPJ,
                            string companyName,
                            string? companyFantasy,
                            string? provinceId,
                            string? cityId)
    {
        public int CustomerSupplierId { get; private set; } = customerSupplierId;
        public string CNPJ { get; set; } = cNPJ;
        public string CompanyName { get; set; } = companyName;
        public string? CompanyFantasy { get; set; } = companyFantasy;
        public string? ProvinceId { get; set; } = provinceId;
        public string? CityId { get; set; } = cityId;
        public AddressBase? Address { get; set; }
        public ContactBase? Contact { get; set; }
        public CreateBase? Create { get; set; }

        public ICollection<People>? Peoples { get; set; }
        public ICollection<FinancialRecord>? FinancialRecords { get; private set; }

    }
}