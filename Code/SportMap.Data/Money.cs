using SportMap.Aids;
using SportMap.Data.Common;

namespace SportMap.Data;

public class Money : BaseEntity {
    [Random(0, 100, 2)] public decimal Amount { get; set; }
    public Guid CurrencyId { get; set; }
    public Currency Currency { get; set; }
}
