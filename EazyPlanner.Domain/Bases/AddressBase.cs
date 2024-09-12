namespace EazyPlanner.Domain.Base
{
    public class AddressBase(string streetName, string buildingNumber, string secondaryAddress, string zipCode, string city, string state, string country)
    {
        public string StreetName { get; set; } = streetName;
        public string BuildingNumber { get; set; } = buildingNumber;
        public string SecondaryAddress { get; set; } = secondaryAddress;
        public string ZipCode { get; set; } = zipCode;
        public string City { get; set; } = city;
        public string State { get; set; } = state;
        public string Country { get; set; } = country;
    }
}
