namespace EazyPlanner.Data.Bases
{
    public class CreateBase
    {
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime UpdateAt { get; set; } = DateTime.UtcNow;
    }
}
