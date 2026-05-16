using SportMap.Data;

namespace SportMap.Infra;

public class MoviesRepo(SportMapDbContext c = null)
    : EfBaseRepo<SportMapDbContext, Movie>(c), IMoviesRepo { }
public class CurrenciesRepo(SportMapDbContext c = null)
    : EfBaseRepo<SportMapDbContext, Currency>(c), ICurrenciesRepo { }
public class CountriesRepo(SportMapDbContext c = null)
    : EfBaseRepo<SportMapDbContext, Country>(c), ICountriesRepo { }
public class MoneyRepo(SportMapDbContext c = null)
    : EfBaseRepo<SportMapDbContext, Money>(c), IMoneyRepo { }
public class CountryCurrenciesRepo(SportMapDbContext c = null)
    : EfBaseRepo<SportMapDbContext, CountryCurrency>(c), ICountryCurrenciesRepo { }
