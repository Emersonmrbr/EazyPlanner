using System.ComponentModel.DataAnnotations;

namespace EazyPlanner.Domain.Base
{
    public class CreateBase(string createdBy, DateTime createAt, string updateBy, DateTime updateAt)
    {
        public string CreatedBy { get; set; } = createdBy;
        public DateTime CreateAt { get; set; } = createAt;
        public string UpdateBy { get; set; } = updateBy;
        public DateTime UpdateAt { get; set; } = updateAt;
    }
}


