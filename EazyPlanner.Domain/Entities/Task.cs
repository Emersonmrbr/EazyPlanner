using EazyPlanner.Domain.Base;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace EazyPlanner.Domain.Entities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskList { get; set; }
        public ICollection<People> AssignedTo { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DueDate { get; set; }
        public string TaskDates { get; set; }
        public string ProgressStatus { get; set; }
        public string Priority { get; set; }
        public CreateBase Create { get; set; }
    }
}
