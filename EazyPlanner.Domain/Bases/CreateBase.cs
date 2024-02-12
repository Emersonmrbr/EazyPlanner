namespace EazyPlanner.Domain.Base
{
    public class CreateBase(string? createdBy,
                            DateTime? createDate,
                            string? updateBy,
                            DateTime? updateDate)
    {
        public string? CreatedBy { get; set; } = createdBy;
        public DateTime? CreateDate { get; set; } = createDate;
        public string? UpdateBy { get; set; } = updateBy;
        public DateTime? UpdateDate { get; set; } = updateDate;
    }
}

