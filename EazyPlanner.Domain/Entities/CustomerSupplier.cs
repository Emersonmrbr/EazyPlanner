using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class CustomerSupplier(int id, string cNPJ, string companyName, string companyFantasy, string provinceId, string cityId, AddressBase? address, ContactBase? contact, CreateBase? create, ICollection<People> peoples, ICollection<FinancialRecord> financialRecords, ICollection<Project> projects)
    {
        public int Id { get; private set; } = id;
        public required string CNPJ { get; set; } = cNPJ;
        public required string CompanyName { get; set; } = companyName;
        public string? CompanyFantasy { get; set; } = companyFantasy;
        public string? ProvinceId { get; set; } = provinceId;
        public string? CityId { get; set; } = cityId;

        public AddressBase? Address { get; set; } = address;
        public ContactBase? Contact { get; set; } = contact;
        public CreateBase? Create { get; set; } = create;

        public ICollection<People>? Peoples { get; private set; } = peoples;
        public ICollection<FinancialRecord>? FinancialRecords { get; private set; } = financialRecords;
        public ICollection<Project>? Projects { get; private set; } = projects;

    }
}
