using EazyPlanner.Domain.Base;
using EazyPlanner.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace EazyPlanner.Domain.Entities
{
    public class Task
    {
        public BillingType TaskBillingType { get; set; }
        public bool TaskCompleted { get; set; }
        public bool TaskInvoced { get; set; }
        public CreateBase TaskCreate { get; set; }
        public DateTime TaskDueDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public DateTime TaskStartDate { get; set; }
        public decimal TaskEstimateBillableAmount { get; set; }
        public decimal TaskEstimateCost { get; set; }
        public decimal TaskHourlyRate { get; set; }
        public double TaskEstimateHours { get; set; }
        public double TaskHoursLeft { get; set; }
        public double TaskHoursWorked { get; set; }
        public double TaskProgressStatus { get; set; }
        public double TaskWorkedTotal { get; set; }
        public ICollection<People> AssignedTo { get; set; }
        public ICollection<People> TaskFollowers { get; set; }
        public ICollection<string> TaskList { get; set; }
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public string TaskName { get; set; }
        public string TaskPriority { get; set; }
    }
}
