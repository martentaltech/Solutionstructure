using SportMap.Data;
using SportMap.Data.Common;

namespace SportMap.Infra;

public sealed class Query(Dictionary<string, string> d = null) {
    public static int[] PageSizes => [7, 15, 25, 50, 100];
    public int Page => toInt(get(nameof(Page)), 1);
    public int PageSize => toInt(get(nameof(PageSize)), PageSizes[0]);
    public string SortBy => get(nameof(SortBy));
    public string SortDir => get(nameof(SortDir));
    public string SearchBy => get(nameof(SearchBy));
    public string SearchStr => get(nameof(SearchStr));
    public string Selected => get(nameof(Selected));
    private string get(string s) => (d ?? []).TryGetValue(s, out var x) ? x : null;
    private static int toInt(string s, int def) => int.TryParse(s, out var i) ? i : def;
    private string sort => string.IsNullOrEmpty(SortBy)
        ? string.Empty : $"&{nameof(SortBy)}={SortBy}&{nameof(SortDir)}={SortDir}";
    private string search => string.IsNullOrEmpty(SearchStr)
        ? string.Empty : $"&{nameof(SearchBy)}={SearchBy}&{nameof(SearchStr)}={SearchStr}";
    private string selected(Guid id) => (Selected == id.ToString())
        ? string.Empty : $"&{nameof(Selected)}={id}";
    public string Href(string baseUri, int? page = null, int? pageSize = null)
        => $"{baseUri}?{nameof(Page)}={page ?? Page}&{nameof(PageSize)}={pageSize ?? PageSize}{sort}{search}";
    public string Href(string baseUri, Guid id) => Href(baseUri) + selected(id);
    public string Href(string baseUri, string sortBy) {
        var n = ((SortBy == sortBy) && (SortDir == "desc")) ? null : sortBy;
        var d = SortBy != sortBy ? "asc" : "desc";
        return Href(baseUri, 1);
    }
}

public interface IRepo<TEntity> where TEntity : BaseEntity {
    Task<TEntity> GetAsync(Guid id);
    Task<int> CountAsync(Query q);
    Task<IEnumerable<TEntity>> GetAsync(Query q);
    Task<TEntity> CreateAsync(TEntity e);
    Task<TEntity> UpdateAsync(TEntity e);
    Task DeleteAsync(Guid id);
}

public interface IMoviesRepo : IRepo<Movie> { }
public interface ICountriesRepo : IRepo<Country> { }
public interface ICurrenciesRepo : IRepo<Currency> { }
public interface IMoneyRepo : IRepo<Money> { }
public interface ICountryCurrenciesRepo : IRepo<CountryCurrency> { }
