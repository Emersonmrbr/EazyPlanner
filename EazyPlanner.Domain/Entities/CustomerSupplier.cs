using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
  public class CustomerSupplier
  {
    public CustomerSupplier(int customerSupplierId,
                            string cNPJ,
                            string companyName,
                            string companyFantasy,
                            string provinceId,
                            string cityId)

    {
      CustomerSupplierId = customerSupplierId;
      CNPJ = cNPJ;
      CompanyName = companyName;
      CompanyFantasy = companyFantasy;
      ProvinceId = provinceId;
      CityId = cityId;

    }
    public int CustomerSupplierId { get; private set; }
    public string CNPJ { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string CompanyFantasy { get; set; } = string.Empty;
    public string ProvinceId { get; set; } = string.Empty;
    public string CityId { get; set; } = string.Empty;
    public AddressBase Address { get; set; } = new AddressBase(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
    public ContactBase Contact { get; set; } = new ContactBase(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
    public CreateBase Create { get; set; } = new CreateBase(string.Empty, DateTime.MinValue, string.Empty, DateTime.MinValue);

    public ICollection<People> Peoples { get; set; } = [];
    public ICollection<FinancialRecord>? FinancialRecords { get; private set; } = [];

  }
}
