namespace EazyPlanner.Domain.Base
{
  public class AddressBase
  {
    public AddressBase(string streetName,
                           string buildingNumber,
                           string secondaryAddress,
                           string zipCode,
                           string city,
                           string state,
                           string country)
    {
      StreetName = streetName;
      BuildingNumber = buildingNumber;
      SecondaryAddress = secondaryAddress;
      ZipCode = zipCode;
      City = city;
      State = state;
      Country = country;
    }


    public string StreetName { get; set; } = string.Empty;
    public string BuildingNumber { get; set; } = string.Empty;
    public string SecondaryAddress { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
  }
  //public record AddressBase(string? streetName, string? buildingNumber, string? secondaryAddress, string? zipCode, string? city, string? state, string? country)
  //{
  //}
}
