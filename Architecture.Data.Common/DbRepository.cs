namespace Architecture.Data.Common
{
    using System.Data.Entity;
    using System.Linq;

    public class DbRepository<T> : IDbRepository<T> where T : BaseModel<T>
    {
        private DbContext context;
        private DbSet<T> entities;

        public DbRepository(DbContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            this.entities.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
        }

        public void Delete(int id)
        {
            var entityToDelete = this.entities.Find(id);

            if (entityToDelete != null)
            {
                entityToDelete.IsDeleted = true;
            }
        }

        public IQueryable<T> GetAll()
        {
            return this.entities.Where(e => !e.IsDeleted);
        }

        public IQueryable<T> GetAllWithDeleted()
        {
            return this.entities;
        }

        public T GetById(int id)
        {
            return this.entities.Find(id);
        }

        public void HardDelete(T entity)
        {
            this.entities.Remove(entity);
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
