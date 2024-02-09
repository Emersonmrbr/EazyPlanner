using System.ComponentModel.DataAnnotations;

namespace EazyPlanner.Domain.Entities
{
    public class _ContactBase
    {
        [StringLength(100, ErrorMessage = "The Address street field cannot be longer than 100 characters")]
        [DataType(DataType.Text)]
        public string? StreetName { get; set; }

        [StringLength(30, ErrorMessage = "The Building number field cannot be longer than 30 characters")]
        [DataType(DataType.Text)]
        public string? BuildingNumber { get; set; }

        [StringLength(50, ErrorMessage = "The Secondary address field cannot be longer than 50 characters")]
        [DataType(DataType.Text)]
        public string? SecondaryAddress { get; set; }

        [DataType(DataType.PostalCode)]
        [StringLength(50, ErrorMessage = "The Zip code field cannot be longer than 50 characters")]
        public string? ZipCode { get; set; }

        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The City field cannot be longer than 100 characters")]
        public string? City { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The City field cannot be longer than 50 characters")]
        public string? State { get; set; }

        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The Country field cannot be longer than 100 characters")]
        public string? Country { get; set; }

        [StringLength(200, ErrorMessage = "The Website field cannot be longer than 200 characters")]
        [DataType(DataType.Url)]
        public string? Website { get; set; }

        [StringLength(50, ErrorMessage = "The Phone 1 field cannot be longer than 50 characters")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone1 { get; set; }

        [StringLength(50, ErrorMessage = "The Phone 2 field cannot be longer than 50 characters")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone2 { get; set; }

        [StringLength(100, ErrorMessage = "The Email 1 field cannot be longer than 200 characters")]
        [DataType(DataType.EmailAddress)]
        public string? Email1 { get; set; }

        [StringLength(100, ErrorMessage = "The Email 2 field cannot be longer than 100 characters")]
        [DataType(DataType.EmailAddress)]
        public string? Email2 { get; set; }

        public byte[]? Image { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The Created by field cannot be longer than 50 characters")]
        public string? CreatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateDate { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The Update by field cannot be longer than 50 characters")]
        public string? UpdateBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }
    }
}

