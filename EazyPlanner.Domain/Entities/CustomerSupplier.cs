using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class CustomerSupplier
    {
        public CustomerSupplier(int customerSupplierId,
                                string cNPJ,
                                string companyName,
                                string? companyFantasy,
                                string? provinceId,
                                string? cityId)
        {
            CustomerSupplierId = customerSupplierId;
            CNPJ = cNPJ;
            CompanyName = companyName;
            CompanyFantasy = companyFantasy;
            ProvinceId = provinceId;
            CityId = cityId;
        }

        public int CustomerSupplierId { get; private set; }
        public string CNPJ { get; set; }
        public string CompanyName { get; set; }
        public string? CompanyFantasy { get; set; }
        public string? ProvinceId { get; set; }
        public string? CityId { get; set; }
        public AddressBase? Address { get; set; }
        public ContactBase? Contact { get; set; }
        public CreateBase? Create { get; set; }

        public ICollection<People>? Peoples { get; set; } = new List<People>();
        public ICollection<FinancialRecord>? FinancialRecords { get; private set; } = new List<FinancialRecord>();
    }
}
