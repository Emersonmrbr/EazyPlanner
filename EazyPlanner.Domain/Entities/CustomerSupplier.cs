using EazyPlanner.Domain.Bases;

namespace EazyPlanner.Domain.Entities
{
    public class CustomerSupplier(int id, string cNPJ, string companyName)
    {
        public int Id { get; private set; } = id;
        public string CNPJ { get; set; } = cNPJ;
        public string CompanyName { get; set; } = companyName;
        public string? CompanyFantasy { get; set; } = string.Empty;
        public string? ProvinceId { get; set; } = string.Empty;
        public string? CityId { get; set; } = string.Empty;

        public AddressBase? Address { get; set; } = new();
        public ContactBase? Contact { get; set; } = new();
        public CreateBase? Create { get; set; } = new();

        public ICollection<People>? Peoples { get; set; } = [];
        public ICollection<FinancialRecord>? FinancialRecords { get; set; } = [];
        public ICollection<Project>? Projects { get; set; } = [];

    }
}
