using SportMap.Data;
using SportMap.Data.Common;

namespace SportMap.Infra;

public interface IRepo<TEntity> where TEntity : BaseEntity {
    Task<TEntity> GetAsync(Guid id);
    Task<IEnumerable<TEntity>> GetAsync();
    Task<TEntity> CreateAsync(TEntity e);
    Task<TEntity> UpdateAsync(TEntity e);
    Task DeleteAsync(Guid id);
}

public interface IMoviesRepo : IRepo<Movie> { }
public interface ICountriesRepo : IRepo<Country> { }
public interface ICurrenciesRepo : IRepo<Currency> { }
