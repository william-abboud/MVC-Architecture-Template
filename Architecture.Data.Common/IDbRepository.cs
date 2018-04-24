namespace Architecture.Data.Common
{
    using System.Linq;

    public interface IDbRepository<T> : IDbRepository<T, int>
        where T : BaseModel<T>
    {
    }

public interface IDbRepository<T, in TKey> where T : class
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetAllWithDeleted();

        T GetById(TKey id);

        void Add(T entity);

        void Delete(T entity);

        void HardDelete(T entity);

        void Delete(TKey id);

        void Save();
    }
}
