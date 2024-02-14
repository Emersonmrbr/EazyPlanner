namespace EazyPlanner.Domain.Base
{
    public class CreateBase
    {
        public CreateBase(string? createdBy,
                                DateTime? createAt,
                                string? updateBy,
                                DateTime? updateAt)
        {
            CreatedBy = createdBy;
            CreateAt = createAt;
            UpdateBy = updateBy;
            UpdateAt = updateAt;
        }
        public string? CreatedBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}


