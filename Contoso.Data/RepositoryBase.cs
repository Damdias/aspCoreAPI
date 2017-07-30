using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public abstract class RepositoryBase<T> where T : class
    {
        private readonly IDatabase _dbContext;
        public RepositoryBase(IDatabase database)
        {
            _dbContext = database;
        }
      public virtual   IQueryable<T> GetAll()
        {
            return _dbContext.GetDbSet<T>();
        }
        public virtual T Get(int id)
        {
            return _dbContext.GetDbSet<T>().Find(id);
        }
        public virtual  async Task<T> GetAsync(int id)
        {
            return await _dbContext.GetDbSet<T>().FindAsync(id);
        }

    }
}
