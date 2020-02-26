using System.Linq;
using System.Threading.Tasks;

namespace RumosCRE.Domain.Interfaces
{
    public interface IRepository<TEntity, in TId> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(TId id);
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
