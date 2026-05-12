using SportMap.Data.Common;

namespace SportMap.Data;

public class CountryCurrency : DetailedEntity {
    public Guid CountryId { get; set; }
    public Guid CurrencyId { get; set; }
    public Currency Currency { get; set; }
}
