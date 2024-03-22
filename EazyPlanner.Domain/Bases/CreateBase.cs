namespace EazyPlanner.Domain.Base
{
    public class CreateBase
    {
        public CreateBase(string createdBy,
                                DateTime createAt,
                                string updateBy,
                                DateTime updateAt)
        {
            CreatedBy = createdBy;
            CreateAt = createAt;
            UpdateBy = updateBy;
            UpdateAt = updateAt;
        }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = new();
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime UpdateAt { get; set; } = new();
    }
}


