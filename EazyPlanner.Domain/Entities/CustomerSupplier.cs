using EazyPlanner.Domain.Entities.Base;

namespace EazyPlanner.Domain.Entities
{
    public class CustomerSupplier
    {
        public CustomerSupplier(int customerSupplierId,
                                string cNPJ,
                                string companyName,
                                string? companyFantasy,
                                string? provinceId,
                                string? cityId,
                                AddressBase? address,
                                CreateBase? create)
        {
            CustomerSupplierId = customerSupplierId;
            CNPJ = cNPJ;
            CompanyName = companyName;
            CompanyFantasy = companyFantasy;
            ProvinceId = provinceId;
            CityId = cityId;
            Address = address;
            Create = create;
        }

        public int CustomerSupplierId { get; private set; }
        public string CNPJ { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string? CompanyFantasy { get; set; } = null;
        public string? ProvinceId { get; set; } = null;
        public string? CityId { get; set; } = null;
        public AddressBase? Address { get; set; }
        public CreateBase? Create { get; set; }

    }
}