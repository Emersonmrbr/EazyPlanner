namespace EazyPlanner.Domain.Base
{
    public class ContactBase
    {
        public ContactBase(string phone1,
                                 string phone2,
                                 string email1,
                                 string email2,
                                 string website,
                                 string image)
        {
            Phone1 = phone1;
            Phone2 = phone2;
            Email1 = email1;
            Email2 = email2;
            Website = website;
            Image = image;
        }
        public string Phone1 { get; set; } = string.Empty;
        public string Phone2 { get; set; } = string.Empty;
        public string Email1 { get; set; } = string.Empty;
        public string Email2 { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}

