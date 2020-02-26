using Microsoft.EntityFrameworkCore;
using RumosCRE.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace RumosCRE.Infra.Data.Repositories
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {

        protected readonly DbSet<TEntity> DbSet;

        protected Repository(DbContext context)
        {
            DbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public async Task<TEntity> GetById(TId id)
        {
            return await DbSet.FindAsync(id);
        }

        public async void Add(TEntity obj)
        {
            await DbSet.AddAsync(obj);
        }

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            DbSet.Remove(obj);
        }
    }
}
