using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{


  public class BankrollAccount(
      int bankrollAccountId,
      string name)
  {
    public int BankrollAccountId { get; private set; } = bankrollAccountId;
    public required string Name { get; set; } = name;
    public CreateBase Create { get; set; } = new CreateBase(string.Empty, DateTime.Now, string.Empty, DateTime.Now);

    public ICollection<FinancialRecord>? FinancialRecords { get; private set; } = [];
  }
}
