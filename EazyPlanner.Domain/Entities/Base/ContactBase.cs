using System.ComponentModel.DataAnnotations.Schema;

namespace EazyPlanner.Domain.Entities.Base
{
    [ComplexType]
    public class ContactBase(string? phone1,
                             string? phone2,
                             string? email1,
                             string? email2,
                             string? website,
                             byte[]? image)
    {
        public string? Phone1 { get; set; } = phone1;
        public string? Phone2 { get; set; } = phone2;
        public string? Email1 { get; set; } = email1;
        public string? Email2 { get; set; } = email2;
        public string? Website { get; set; } = website;
        public byte[]? Image { get; set; } = image;
    }
}

