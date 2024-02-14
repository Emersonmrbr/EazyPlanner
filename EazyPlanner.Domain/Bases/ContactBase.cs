namespace EazyPlanner.Domain.Base
{
    public class ContactBase
    {
        public ContactBase(string? phone1,
                                 string? phone2,
                                 string? email1,
                                 string? email2,
                                 string? website,
        byte[]? image)
        {
            Phone1 = phone1;
            Phone2 = phone2;
            Email1 = email1;
            Email2 = email2;
            Website = website;
            Image = image;
        }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public string? Website { get; set; }
        public byte[]? Image { get; set; }
    }
}

